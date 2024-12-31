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

            string sql = $@"SELECT `id`, `konten_percakapan` AS `kp`, waktu_kirim AS `wk` 
                            FROM `percakapan` 
                            WHERE (`pengirim` = '{sender.Username}' AND `penerima` = '{receiver.Username}')
                            OR (`pengirim` = '{receiver.Username}' AND `penerima` = '{sender.Username}')
                            ORDER BY `wk` DESC";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while(resultSet.Read())
            {
                int id = resultSet.GetInt32("id");
                string pesan = resultSet.GetString("kp");
                DateTime waktuKirim = resultSet.GetDateTime("wk");

                result.Add(new Percakapan(id, pesan, waktuKirim));
            }

            connection.Close();
            return result;
        }

        public bool Insert_Chat(Percakapan percakapan)
        {
            string sql = $@"INSERT INTO `percakapan` (`pengirim`, `penerima`, `konten_percakapan`, `waktu_kirim`)
                            VALUES ('{percakapan.Pengirim}', '{percakapan.Penerima}', '{percakapan.Pesan}', 
                                    '{percakapan.WaktuKirim.ToString("yyyy-MM-dd HH:mm:ss")}')";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }
    }
}