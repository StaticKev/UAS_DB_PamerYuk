using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using Class_PamerYuk;
using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class KontenDAO
    {
        private readonly Connection connection;

        public enum OwnedBy
        {
            CURRENT_USER,
            FRIEND
        }

        public enum Table
        {
            TAG,
            LIKE
        }

        public KontenDAO(Connection connection) { this.connection = connection; }

        public List<Konten> Read_Content(User user, OwnedBy ownedBy)
        {
            List<Konten> result = new List<Konten>();

            string sql = "";

            if (ownedBy.Equals(OwnedBy.CURRENT_USER))
            {
                sql = $@"SELECT k.`id` `idKonten`, k.`caption`, k.`foto` `fotoK`, k.`video`, k.`tglupload`
                         FROM `konten` k
                         WHERE k.`username` = '{user.Username}'
                         ORDER BY k.`id` DESC";
            } 
            else
            {
                sql = $@"SELECT k.`id` `idKonten`, k.`caption`, k.`foto` `fotoK`, k.`video`, k.`tglupload`, 
                                u.`username`, u.`tgllahir`, u.`noktp`, u.`foto` `fotoU`, kt.`id` `idKota`, kt.`nama`
                         FROM `konten` k
                         INNER JOIN `user` u ON (k.`username` = u.`username`)
                         INNER JOIN `teman` t ON (u.`username` = t.`username1` OR u.`username` = t.`username2`)
                         INNER JOIN `kota` kt ON (u.`kota_id` = kt.`id`)
                         WHERE (t.`username1` = '{user.Username}' OR t.`username2` = '{user.Username}')
                         AND u.`username` != '{user.Username}'
                         AND t.`tglberteman` IS NOT NULL
                         ORDER BY k.`id` DESC";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                int idKonten = resultSet.GetInt32("idKonten");
                string caption = resultSet.GetString("caption") != "-" ? resultSet.GetString("caption") : "-"; // BISA NULL
                string foto = resultSet.GetString("fotoK") != "-" ? resultSet.GetString("fotoK") : "-"; // BISA NULL
                string video = resultSet.GetString("video") != "-" ? resultSet.GetString("video") : "-"; // BISA NULL
                DateTime tglUpload = resultSet.GetDateTime("tglupload");

                if (ownedBy.Equals(OwnedBy.CURRENT_USER))
                {
                    result.Add(new Konten(idKonten, user, caption, foto, video, tglUpload));
                } 
                else
                {
                    string username = resultSet.GetString("username");
                    DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                    string noKTP = resultSet.GetString("noktp");
                    string fotoProfil = resultSet.GetString("fotoU");

                    int idKota = resultSet.GetInt32("idKota");
                    string namaKota = resultSet.GetString("nama");

                    Kota k = new Kota(idKota, namaKota);
                    User u = new User(username, tglLahir, noKTP, fotoProfil, k);
                    result.Add(new Konten(idKonten, u, caption, foto, video, tglUpload));
                }
            }

            return result;
        }

        public List<Komen> Read_Comment(Konten konten) 
        {
            List<Komen> result = new List<Komen>();

            string sql = $@"SELECT k.`id` `idKomentar`, k.`komentar`, k.`tgl`, 
                            u.`username`, u.`tgllahir`, u.`noktp`, u.`foto`, kt.`id` `idKota`, kt.`nama`
                            FROM `komen` k 
                            INNER JOIN `user` u ON (k.`username` = u.`username`)
                            INNER JOIN `kota` kt ON (u.`kota_id` = kt.`id`)
                            WHERE k.`konten_id` = {konten.Id}
                            ORDER BY k.`id` DESC";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                int idKomentar = resultSet.GetInt32("idKomentar");
                string komentar = resultSet.GetString("komentar");
                DateTime tgl = resultSet.GetDateTime("tgl");

                string username = resultSet.GetString("username");
                DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                string noKTP = resultSet.GetString("noktp");
                string foto = resultSet.GetString("foto");

                int idKota = resultSet.GetInt32("idKota");
                string nama = resultSet.GetString("nama");

                Kota kt = new Kota(idKota, nama);
                User u = new User(username, tglLahir, noKTP, foto, kt);
                result.Add(new Komen(idKomentar, komentar, tgl, u));
            }

            return result;
        }

        public int Insert_Content(Konten konten)
        {
            string sql = $@"INSERT INTO `konten` (`caption`, `foto`, `video`, `tglupload`, `username`) 
                            VALUES ('{konten.Caption}', '{konten.Foto}', '{konten.Video}', 
                                    '{konten.TanggalUpload.ToString("yyyy-MM-dd HH:mm:ss")}', 
                                    '{konten.User.Username}')";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            string sql2 = $"SELECT MAX(id) AS `id` FROM konten";
            MySqlCommand cmd2 = new MySqlCommand(sql2, connection.GetConnection());
            MySqlDataReader resultSet = cmd2.ExecuteReader();

            int lastIndex = 0;
            if (resultSet.Read()) lastIndex = resultSet.GetInt32("id"); 

            return lastIndex;
        }

        public bool Insert_LikeOrTag(Table table, Konten konten, User user)
        {
            string sql = $@"INSERT INTO `{table.ToString()}` (`konten_id`, `username`)
                            VALUES ({konten.Id}, '{user.Username}')";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }

        public bool Insert_Comment(Konten konten, Komen komen)
        {
            string sql = $@"INSERT INTO `komen` (`komentar`, `tgl`, `username`, `konten_id`)
                            VALUES ('{komen.Komentar}', '{komen.Tgl.ToString("yyyy-MM-dd HH:mm:ss")}', 
                                    '{komen.User.Username}', {konten.Id})";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }

        public bool Delete_Like(Konten konten, User user)
        {
            string sql = $@"DELETE FROM `like` WHERE `konten_id` = {konten.Id} AND `username` = '{user.Username}'";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }

        public bool Check_Like(Konten konten, User user)
        {
            string sql = $@"SELECT COUNT(*) FROM `like` WHERE `Konten_id` = {konten.Id} AND `username` = '{user.Username}'";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();
            int result = resultSet.Read() ? resultSet.GetInt32(0) : 0;

            connection.Close();
            return result > 0 ? true : false;
        }
    }
}
