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

        public List<User> FindUserByUsername(User user, User currentUser)
        {
            List<User> result = userDAO.Read_FindByUsername(user, currentUser);

            if (result.Count == 0) throw new Exception("User not found!");
            else return result;
        }

        public List<User> FindUserByOrganisasi(Organisasi organisasi, User currentUser)
        {
            List<User> result = userDAO.Read_FindByOrganization(organisasi, currentUser);

            if (result.Count == 0) throw new Exception("User not found!");
            else return result;
        } 

        public List<Organisasi> GetOrganizations()
        {
            return organisasiDAO.Read_All();
        }
    }
}
