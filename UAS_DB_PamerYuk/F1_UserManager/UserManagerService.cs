using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F3_Chat
{
    public class UserManagerService
    {
        private readonly UserDAO userDAO;
        private readonly OrganisasiDAO organisasiDAO;

        public UserManagerService(Connection connection)
        {
            userDAO = new UserDAO(connection);
            organisasiDAO = new OrganisasiDAO(connection);
        }
    }
}
