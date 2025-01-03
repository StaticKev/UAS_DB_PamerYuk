﻿using System;
using System.Collections.Generic;
using Class_PamerYuk;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class UserDAO
    {
        private readonly Connection connection;

        public enum Table
        {
            LIKE, // Mencari berdasarkan id konten
            TAG // Mencari berdasarkan id konten
        }

        public enum FriendshipStatus
        {
            FRIEND, 
            NOT_FRIEND
        }

        public UserDAO(Connection connection) { this.connection = connection; }

        public bool Read_CheckUsername(string username)
        {
            string sql = $"SELECT COUNT(*) AS `count` FROM `user` WHERE `username` = '{username}'";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();
            connection.Close();

            int count = resultSet.Read() ? resultSet.GetInt32("count") : 0;

            return count == 0 ? true : false;
        } 

        public User Read_Login(string username, string password)
        {
            User result = null;

            string sql = $@"SELECT u.`username`, u.`tgllahir`, u.`noKTP`, u.`foto`, k.`id`, k.`nama`
                            FROM `user` u
                            INNER JOIN `kota` k ON (u.`kota_id` = k.`id`)
                            WHERE `username` = '{username}' 
                            AND `password` = '{password}'";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            if (resultSet.Read())
            {
                username = resultSet.GetString("username");
                DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                string noKTP = resultSet.GetString("noktp");
                string foto = resultSet.GetString("foto");

                int id = resultSet.GetInt32("id");
                string nama = resultSet.GetString("nama");
                Kota kota = new Kota(id, nama);

                result = new User(username, tglLahir, noKTP, foto, kota);
            }

            connection.Close();
            return result;
        }

        public List<User> Read_FindById(Table table, int id)
        {
            List <User> result = new List<User>();

            string sql = "";

            sql = $@"SELECT u.`username`, u.`tgllahir`, u.`noKTP`, u.`foto`, k.`id`, k.`nama`
                     FROM `user` u
                     INNER JOIN `{table.ToString()}` j ON (u.`username` = j.`username`)
                     WHERE j.`konten_id` = {id}";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                string username = resultSet.GetString("username");
                DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                string noKTP = resultSet.GetString("noktp");
                string foto = resultSet.GetString("foto");

                int idKota = resultSet.GetInt32("id");
                string nama = resultSet.GetString("nama");
                Kota kota = new Kota(idKota, nama);

                result.Add(new User(username, tglLahir, noKTP, foto, kota));
            }

            connection.Close();
            return result;
        }

        public List<User> Read_AllFriend(User user, FriendshipStatus status)
        {
            List<User> result = new List<User>();

            string isFriend = status.Equals(FriendshipStatus.FRIEND) ? "NOT NULL" : "NULL";
            string sql = $@"SELECT u.`username`, u.`tgllahir`, u.`noKTP`, u.`foto`, k.`id`, k.`nama`
                            FROM `user` u 
                            INNER JOIN `teman` t ON (u.`username` = t.`username1` OR u.`username` = t.`username2`)
                            INNER JOIN `kota` k ON (u.`kota_id` = k.`id`)
                            WHERE (t.`username1` = '{user.Username}'
                            OR t.`username2` = '{user.Username}')
                            AND u.`username` != '{user.Username}'
                            AND t.`tglberteman` IS {isFriend}";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                string username = resultSet.GetString("username");
                DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                string noKTP = resultSet.GetString("noktp");
                string foto = resultSet.GetString("foto");

                int idKota = resultSet.GetInt32("id");
                string nama = resultSet.GetString("nama");
                Kota kota = new Kota(idKota, nama);

                result.Add(new User(username, tglLahir, noKTP, foto, kota));
            }

            connection.Close();
            return result;
        }

        public List<User> Read_FindByUsername(User user, User currentUser)
        {
            List<User> result = new List<User>();

            string sql = $@"SELECT u.`username`, u.`tgllahir`, u.`noKTP`, u.`foto`, k.`id`, k.`nama`
                            FROM `user` u 
                            INNER JOIN `kota` k ON (u.`kota_id` = k.`id`)
                            INNER JOIN `teman` t ON (u.`username` = t.`username1` OR u.`username` = t.`username2`)
                            WHERE u.`username` = {user.Username}
                            AND (t.`username1` = '{currentUser.Username}' OR t.`username2` = '{currentUser.Username}')
                            AND u.`username` != '{currentUser.Username}'";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                string username = resultSet.GetString("username");
                DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                string noKTP = resultSet.GetString("noktp");
                string foto = resultSet.GetString("foto");

                int idKota = resultSet.GetInt32("id");
                string nama = resultSet.GetString("nama");
                Kota kota = new Kota(idKota, nama);

                result.Add(new User(username, tglLahir, noKTP, foto, kota));
            }

            return null;
        }

        public List<User> Read_FindByOrganization(Organisasi organisasi, User currentUser)
        {
            List<User> result = new List<User>();

            string sql = $@"SELECT u.`username`, u.`tgllahir`, u.`noKTP`, u.`foto`, k.`id`, k.`nama`
                            FROM `user` u
                            INNER JOIN `kisahhidup` h ON (u.`username` = h.`username`)
                            INNER JOIN `organisasi` o ON (h.`organisasi_id` = o.`id`)
                            INNER JOIN `kota` k ON (u.`kota_id` = k.`id`)
                            WHERE h.`organisasi_id` = {organisasi.Id}
                            AND u.`username` NOT IN (
                            SELECT u.`username`
                                FROM `user` u
                                INNER JOIN `teman` t ON (u.`username` = t.`username1` OR u.`username` = t.`username2`)
                                WHERE (t.`username1` = '{currentUser.Username}' OR t.`username2` = '{currentUser.Username}')
                                AND u.`username` != '{currentUser.Username}'
                            )";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            MySqlDataReader resultSet = cmd.ExecuteReader();

            while (resultSet.Read())
            {
                string username = resultSet.GetString("username");
                DateTime tglLahir = resultSet.GetDateTime("tgllahir");
                string noKTP = resultSet.GetString("noktp");
                string foto = resultSet.GetString("foto");

                int idKota = resultSet.GetInt32("id");
                string nama = resultSet.GetString("nama");
                Kota kota = new Kota(idKota, nama);

                result.Add(new User(username, tglLahir, noKTP, foto, kota));
            }

            return result;
        }

        public bool Insert_RegisterUser(User user)
        {
            string sql = $@"INSERT INTO `user` (`username`, `password`, `tgllahir`, `noktp`, `foto`, `kota_id`) 
                            VALUES ('{user.Username}', '{user.Password}', 
                                    '{user.TglLahir.ToString("yyyy-MM-dd")}', '{user.NoKTP}', 
                                    '{user.Foto}', {user.Kota.Id})";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }

        public bool Insert_AddFriend(User sender, User receiver)
        {
            string sql = $@"INSERT INTO `teman` (`username1`, `username2`)
                            VALUES ('{sender.Username}', '{receiver.Username}')";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }

        public bool Update_AcceptFriend(User receiver, User sender)
        {
            string sql = $@"UPDATE `teman` 
                            SET `tglberteman` = '{DateTime.Now.ToString("yyyy-MM-dd")}'
                            WHERE `username1` = '{sender.Username}' 
                            AND `username2` = '{receiver.Username}'";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            int ar = cmd.ExecuteNonQuery();

            connection.Close();
            return ar > 0 ? true : false;
        }
    }
}