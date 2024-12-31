using MySql.Data.MySqlClient;
using System.Configuration;

namespace UAS_DB_PamerYuk
{
    public class Connection
    {
        private MySqlConnection dbConnection;

        private MySqlConnection DbConnection { get => dbConnection; set => dbConnection = value; }

        public Connection()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["UAS_DB_PamerYuk.Properties.DB"] as ClientSettingsSection;

            string pS = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string pD = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string pU = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string pP = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText; // Kalau mau run, pakai yang bawah. 
            // string pP = "";

            string conString = "Server=" + pS + ";Database=" + pD + ";Uid=" + pU + ";Pwd=" + pP + ";";
            DbConnection = new MySqlConnection(conString);
        }

        public MySqlConnection GetConnection()
        {
            if (DbConnection.State == System.Data.ConnectionState.Open) DbConnection.Close();
            DbConnection.Open();

            return DbConnection;
        }

        public void Close()
        {
            if (DbConnection.State == System.Data.ConnectionState.Open) DbConnection.Close();
        }
    }
}
