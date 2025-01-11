using Class_PamerYuk;
using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class SingleUserRequestUC : UserControl
    {
        private readonly User user;
        private readonly MainForm mainForm;
        private readonly NotificationUC notificationUC;
        private readonly ContentService service;
        private readonly FileRepo fileRepo;

        public SingleUserRequestUC(User user, MainForm mainForm, NotificationUC notificationUC, ContentService service)
        {
            InitializeComponent();
            this.user = user;
            this.mainForm = mainForm;
            this.notificationUC = notificationUC;
            this.fileRepo = new FileRepo();
            this.service = service;
        }

        private void SingleUserRequest_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = user.Username;
            pPictPanel.BackgroundImage = fileRepo.RetrieveImage(user.Foto);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            service.AcceptFriendRequest(mainForm.currentUser, user);
            MessageBox.Show("Berhasil menerima permintaan pertemanan!");
            notificationUC.NotificationUC_Load_1(sender, e);
        }
    }
}
