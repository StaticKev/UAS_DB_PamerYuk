using Class_PamerYuk;
using System;
using System.Windows.Documents;
using System.Collections.Generic;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public class ChatService
    {
        private readonly UserDAO userDAO;
        private readonly PercakapanDAO percakapanDAO;

        public ChatService(Connection connection)
        {
            userDAO = new UserDAO(connection);
            percakapanDAO = new PercakapanDAO(connection);
        }

        public List<User> GetFriend(User user)
        {
            return userDAO.Read_AllFriend(user, UserDAO.FriendshipStatus.FRIEND);
        }

        public List<Percakapan> RetrieveChatHistory(User sender, User receiver)
        {
            return percakapanDAO.Read_ByUser(sender, receiver);
        }

        public void SendMessage(Percakapan percakapan)
        {
            if (!percakapanDAO.Insert_Chat(percakapan)) throw new Exception("PESAN GAGAL TERKIRIM ERORRRRRRR");
        }
    }
}
