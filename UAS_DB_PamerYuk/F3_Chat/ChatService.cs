using MySql.Data.MySqlClient;
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
    }
}
