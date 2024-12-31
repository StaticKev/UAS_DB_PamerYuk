using System.Collections.Generic;
using Class_PamerYuk;
using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.DAO
{
    public class KotaDAO
    {
        private readonly Connection connection;

        public KotaDAO(Connection connection) { this.connection = connection; }

        public List<Kota> Read_All()
        {
            List<Kota> result = new List<Kota>();

            string sql = "SELECT * FROM `kota`";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                int id = resultSet.GetInt32("id");
                string nama = resultSet.GetString("nama");

                result.Add(new Kota(id, nama));
            }

            connection.Close();
            return result;
        }
    }
}