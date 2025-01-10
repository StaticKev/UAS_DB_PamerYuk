using System;
using System.Collections.Generic;
using Class_PamerYuk;
using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class PercakapanDAO
    {
        private readonly Connection connection;

        public PercakapanDAO(Connection connection) { this.connection = connection; }

        public List<Percakapan> Read_ByUser(User sender, User receiver)
        {
            List<Percakapan> result = new List<Percakapan>();

            string sql = $@"SELECT p.`konten_percakapan` AS `kp`, p.`waktu_kirim` AS `wk`, p.`pengirim`
                            FROM `percakapan` p
                            INNER JOIN `user` u1 ON (p.`pengirim` = u1.`username`)
                            INNER JOIN `user` u2 ON (p.`penerima` = u2.`username`)
                            WHERE (`pengirim` = '{sender.Username}' AND `penerima` = '{receiver.Username}')
                            OR (`pengirim` = '{receiver.Username}' AND `penerima` = '{sender.Username}')
                            ORDER BY `wk` ASC";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while(resultSet.Read())
            {
                string pesan = resultSet.GetString("kp");
                DateTime waktuKirim = resultSet.GetDateTime("wk");

                User pengirim = null;
                User penerima = null;

                string namaPengirim = resultSet.GetString("pengirim");
                if (namaPengirim.Equals(sender.Username))
                {
                    pengirim = sender;
                    penerima = receiver;
                } 
                else
                {
                    pengirim = receiver;
                    penerima = sender;
                }


                result.Add(new Percakapan(pesan, waktuKirim, pengirim, penerima));
            }

            connection.Close();
            return result;
        }

        public bool Insert_Chat(Percakapan percakapan)
        {
            string sql = $@"INSERT INTO `percakapan` (`pengirim`, `penerima`, `konten_percakapan`, `waktu_kirim`)
                            VALUES ('{percakapan.Pengirim.Username}', '{percakapan.Penerima.Username}', '{percakapan.Pesan}', 
                                    '{percakapan.WaktuKirim.ToString("yyyy-MM-dd HH:mm:ss")}')";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }
    }
}