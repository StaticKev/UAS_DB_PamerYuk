using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F4_Content
{
    public class FriendshipService
    {
        private readonly UserDAO userDAO;

        public FriendshipService(Connection connection)
        {
            userDAO = new UserDAO(connection);
        }
    }
}
