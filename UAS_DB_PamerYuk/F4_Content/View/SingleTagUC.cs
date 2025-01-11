using Class_PamerYuk;
using System;
using System.Net.Http;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class SingleTagUC : UserControl
    {
        User user;
        MainForm mainForm;
        ContentService service;
        FileRepo fileRepo;
        ContentUC_P contentUC;
        HomeMenuUC hmUC;

        public SingleTagUC(User user, MainForm mainForm, ContentService service, ContentUC_P contentUC, HomeMenuUC hmUC)
        {
            InitializeComponent();
            this.user = user;
            this.mainForm = mainForm;
            this.service = service;
            fileRepo = new FileRepo();
            this.contentUC = contentUC;
            this.hmUC = hmUC;
        }

        private void SingleTagUC_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = user.Username;
            pPictPanel.BackgroundImage = fileRepo.RetrieveImage(user.Foto);
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            hmUC.taggedUser.Add(user);
            buttonTag.Enabled = false;
        }
    }
}
