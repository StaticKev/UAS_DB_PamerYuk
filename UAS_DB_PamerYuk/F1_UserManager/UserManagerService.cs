using Class_PamerYuk;
using UAS_DB_PamerYuk.Repository.DAO;
using System;
using UAS_DB_PamerYuk.DAO;
using System.Collections.Generic;

namespace UAS_DB_PamerYuk.F3_Chat
{
    public class UserManagerService
    {
        private readonly UserDAO userDAO;
        private readonly KotaDAO kotaDAO;
        private readonly OrganisasiDAO organisasiDAO;
        private readonly KisahHidupDAO kisahHidupDAO;

        public UserManagerService(Connection connection)
        {
            userDAO = new UserDAO(connection);
            kisahHidupDAO = new KisahHidupDAO(connection);
            organisasiDAO = new OrganisasiDAO(connection);
            kotaDAO = new KotaDAO(connection);
        }

        public User LogIn(User user)
        {
            User result = userDAO.Read_Login(user.Username, user.Password);
            if (result == null) throw new Exception("Incorrect username or password!");
            else return result;
        }

        public void RegisterUser(User user)
        {
            if (!userDAO.Insert_RegisterUser(user)) throw new Exception("Failed to register!");
        }

        public List<Kota> GetAllKota()
        {
            return kotaDAO.Read_All();
        }

        public List<Organisasi> GetAllOrganisasi()
        {
            return organisasiDAO.Read_All();
        }

        public List<User> GetFriend(User user)
        {
            return userDAO.Read_AllFriend(user, UserDAO.FriendshipStatus.FRIEND);
        }

        public List<KisahHidup> GetKisahHidup(User user)
        {
            return kisahHidupDAO.Read_ByUsername(user);
        }

        public void AddKisahHidup(KisahHidup kisahHidup)
        {
            kisahHidupDAO.Insert_KisahHidup(kisahHidup);
        }

        public void AddOrganisasi(Organisasi organisasi)
        {
            organisasiDAO.Insert_Organisasi(organisasi);
        } 

        public void CheckUsername(string username)
        {
            if (!userDAO.Read_CheckUsername(username)) throw new Exception("Username telah digunakan!");
        }
    }
}
