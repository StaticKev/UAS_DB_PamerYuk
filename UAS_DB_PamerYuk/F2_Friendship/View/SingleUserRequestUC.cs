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
using UAS_DB_PamerYuk.F4_Content;
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class SingleUserRequestUC : UserControl
    {
        private readonly User user;
        private readonly FileRepo fileRepo;
        private readonly MainForm mainForm;
        private readonly SearchUC_P searchUC;
        private readonly FriendshipService service;

        public SingleUserRequestUC(User user, MainForm mainForm, SearchUC_P searchUC, FriendshipService service)
        {
            InitializeComponent();
            this.user = user;
            this.fileRepo = new FileRepo();
            this.mainForm = mainForm;
            this.service = service;
            this.searchUC = searchUC;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            service.AddFriend(mainForm.currentUser, user);
            searchUC.comboBox_Organisasi_SelectedIndexChanged(sender, e);

            MessageBox.Show("Berhasil mengirimkan permintaan pertemanan!");
        }

        private void SingleUserRequestUC_Load(object sender, EventArgs e)
        {
            pPictPanel.BackgroundImage = fileRepo.RetrieveImage(user.Foto);
            usernameLabel.Text = user.Username;
        }
    }
}
