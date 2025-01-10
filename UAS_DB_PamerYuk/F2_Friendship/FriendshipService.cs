using System.Collections.Generic;
using Class_PamerYuk;
using UAS_DB_PamerYuk.Repository.DAO;
using System;

namespace UAS_DB_PamerYuk.F4_Content
{
    public class FriendshipService
    {
        private readonly UserDAO userDAO;
        private readonly OrganisasiDAO organisasiDAO;

        public FriendshipService(Connection connection)
        {
            userDAO = new UserDAO(connection);
            organisasiDAO = new OrganisasiDAO(connection);
        }

        public List<User> FindUserByOrganisasi(Organisasi organisasi, User currentUser)
        {
            List<User> result = userDAO.Read_FindByOrganization(organisasi, currentUser);
            return result;
        } 

        public List<Organisasi> GetOrganizations()
        {
            return organisasiDAO.Read_All();
        }

        public void AddFriend(User currentUser, User userToAdd)
        {
            if (!userDAO.Insert_AddFriend(currentUser, userToAdd)) throw new Exception("Tidak bisa menambah user, ERROR DB!");
        }
    }
}
