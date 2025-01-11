using Class_PamerYuk;
using MySql.Data.MySqlClient;
using System.Windows.Documents;
using System.Collections.Generic;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F2_Friendship
{
    public class ContentService
    {
        private readonly UserDAO userDAO;
        private readonly KontenDAO kontenDAO;

        public ContentService(Connection connection)
        {
            userDAO = new UserDAO(connection);
            kontenDAO = new KontenDAO(connection);
        }

        public List<User> RetrieveFriendReq(User user)
        {
            return userDAO.Read_AllFriend(user, UserDAO.FriendshipStatus.NOT_FRIEND);
        } 

        public void AcceptFriendRequest(User receiver, User sender)
        {
            if (!userDAO.Update_AcceptFriend(receiver, sender)) throw new System.Exception("GAGAL MENERIMA PERMINTAAN PERTEMANAN");
        }
    }
}
