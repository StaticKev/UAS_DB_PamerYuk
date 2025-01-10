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
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F3_Chat;

namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    public partial class FriendListUC : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AccountUC_P accountUC;
        private readonly List<User> listUser;

        public FriendListUC(MainForm mainForm, AccountUC_P accountUC, List<User> listUser)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.accountUC = accountUC;
            this.listUser = listUser;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            accountUC.Controls.Remove(this);
            accountUC.panel_profile.Show();
            accountUC.flp_content.Show();
        }

        private void FriendListUC_Load(object sender, EventArgs e)
        {
            foreach (User item in listUser)
            {
                SingleUserUC uc = new SingleUserUC(item);
                flp.Controls.Add(uc);
            }
        }
    }
}
