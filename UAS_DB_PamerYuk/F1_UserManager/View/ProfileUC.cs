using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    public partial class ProfileUC : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AccountUC_P accountUc;
        private readonly FileRepo fileRepo;
        private readonly UserManagerService service;

        public ProfileUC(MainForm mainForm, AccountUC_P accountUc, UserManagerService service)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.accountUc = accountUc;
            fileRepo = new FileRepo();
            this.service = service;
        }

        private void ProfileUC_Load(object sender, EventArgs e)
        {
            label_username.Text = mainForm.currentUser.Username;
            label_noKtp.Text = mainForm.currentUser.NoKTP;
            label_tanggalLahir.Text = mainForm.currentUser.TglLahir.ToString();
            panel_ProfilePict.BackgroundImage = fileRepo.RetrieveImage(mainForm.currentUser.Foto);
        }

        private void Panel_ProfilePict_OnClick(object sender, EventArgs e)
        {

        }

        private void button_friendList_Click(object sender, EventArgs e)
        {
            accountUc.panel_profile.Hide();
            accountUc.flp_content.Hide();
            FriendListUC friendListUC = new FriendListUC(mainForm, accountUc, service.GetFriend(mainForm.currentUser));
            accountUc.Controls.Add(friendListUC);
        }

        private void button_kisahHidup_Click(object sender, EventArgs e)
        {
            accountUc.panel_profile.Hide();
            accountUc.flp_content.Hide();
            ListKisahHidup uc = new ListKisahHidup(mainForm, accountUc, service);
            accountUc.Controls.Add(uc);
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            mainForm.currentUser = null;
            mainForm.MainForm_Load(sender, e);


/*            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, mainForm.currentUser);
            }*/

            using (FileStream fileStream = new FileStream("user.dat", FileMode.Truncate));
        }
    }
}
