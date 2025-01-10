using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    public partial class SingleUserUC : UserControl
    {
        private readonly User user;
        private readonly FileRepo fileRepo;

        public SingleUserUC(User user)
        {
            InitializeComponent();
            this.user = user;
            fileRepo = new FileRepo();
        }

        private void SingleUser_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = user.Username;
            pPictPanel.BackgroundImage = fileRepo.RetrieveImage(user.Foto);
        }
    }
}
