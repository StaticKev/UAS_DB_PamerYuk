using System.Collections.Generic;
using Class_PamerYuk;
using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.DAO
{
    public class KisahHidupDAO
    {
        private readonly Connection connection;

        public KisahHidupDAO(Connection connection) { this.connection = connection; }

        public List<KisahHidup> Read_ByUsername(User user)
        {
            List<KisahHidup> result = new List<KisahHidup>();

            string sql = $@"SELECT kh.`thawal`, kh.`thakhir`, kh.`deskripsi`, 
                                   o.`id` idO, o.`nama` namaO,
                                   kt.`id` idK, kt.`nama` namaK
                            FROM `kisahhidup` kh
                            INNER JOIN `organisasi` o ON (kh.`organisasi_id` = o.`id`)
                            INNER JOIN `kota` kt ON (o.`kota_id` = kt.`id`)
                            WHERE kh.username = '{user.Username}'
                            ORDER BY kh.`organisasi_id`";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while(resultSet.Read())
            {
                string thAwal = resultSet.GetString("thawal");
                string thAkhir = resultSet.GetString("thakhir"); // BISA NULL
                string deskripsi = resultSet.GetString("deskripsi"); // BISA NULL

                int idO = resultSet.GetInt32("idO");
                string namaO = resultSet.GetString("namaO");

                int idK = resultSet.GetInt32("idK");
                string namaK = resultSet.GetString("namaK");

                Kota kota = new Kota(idK, namaK);
                Organisasi organisasi = new Organisasi(idO, namaO, kota);
                result.Add(new KisahHidup(organisasi, user, thAwal, thAkhir, deskripsi));
            }

            connection.Close();
            return result;
        }

        public bool Insert_KisahHidup(KisahHidup kisahHidup)
        {
            string sql = $@"INSERT INTO `kisahhidup` (`organisasi_id`, `username`, `thawal`, `thakhir`, `deskripsi`)
                            VALUES ('{kisahHidup.Organisasi.Id}', '{kisahHidup.User.Username}', '{kisahHidup.Thawal}', 
                                    '{kisahHidup.Thakhir}', '{kisahHidup.Deskripsi}')";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }
    }
}
