using MySql.Data.MySqlClient;
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
    }
}
