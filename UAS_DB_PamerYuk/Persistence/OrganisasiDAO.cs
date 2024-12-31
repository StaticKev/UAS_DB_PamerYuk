using System.Collections.Generic;
using Class_PamerYuk;
using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class OrganisasiDAO
    {
        private readonly Connection connection;

        public OrganisasiDAO(Connection connection) { this.connection = connection; }

        public List<Organisasi> Read_All()
        {
            List<Organisasi> result = new List<Organisasi>();

            string sql = $@"SELECT o.`id` `idO`, o.`nama` `namaO`, k.`id` `idK`, k.`nama` `namaK`
                            FROM `organisasi` o
                            INNER JOIN `kota` k ON (o.`kota_id` = k.`id`)
                            ORDER BY `namaO`";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read()) 
            {
                int idO = resultSet.GetInt32("idO");
                string namaO = resultSet.GetString("namaO");

                int idK = resultSet.GetInt32("idK");
                string namaK = resultSet.GetString("namaK");

                Kota kota = new Kota(idK, namaK);
                result.Add(new Organisasi(idO, namaO, kota));
            }

            connection.Close();
            return result;
        }

        public bool Insert_Organisasi(Organisasi organisasi)
        {
            string sql = $@"INSERT INTO `organisasi` (`nama`, `kota_id`)
                            VALUES ('{organisasi.Nama}', {organisasi.Kota.Id})";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }
    }
}
