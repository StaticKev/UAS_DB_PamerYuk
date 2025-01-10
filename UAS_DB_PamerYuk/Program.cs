using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace UAS_DB_PamerYuk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection connection; 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                connection = new Connection();

                MainForm mainForm = new MainForm(connection);
                Application.Run(mainForm);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Failed");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
