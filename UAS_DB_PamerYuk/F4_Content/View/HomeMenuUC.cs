using Class_PamerYuk;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Collections.Generic;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F2_Friendship.View;
using UAS_DB_PamerYuk.Persistence;
using UAS_DB_PamerYuk.Utility;
using System.Linq;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class HomeMenuUC : UserControl
    {
        private readonly MainForm mainForm;
        private ContentUC_P contentUC_P;
        private readonly ContentService service;
        private readonly FileRepo fileRepo;

        private bool isTyping;
        private Image image;
        private string videoPath;

        public List<User> taggedUser;

        public HomeMenuUC(MainForm mainForm, ContentUC_P contentUC_P, ContentService service)
        {
            InitializeComponent();
            isTyping = false;
            this.mainForm = mainForm;
            this.contentUC_P = contentUC_P;
            this.service = service;
            fileRepo = new FileRepo();

            taggedUser = new List<User>();
        }

        private void HomeMenuUC_Load(object sender, EventArgs e)
        {
            captionTextBox.BackColor = ColorUtil.palette["dim-white"];
            this.ActiveControl = notificationButton;
            sendLabel.BackColor = ColorUtil.palette["charcoal-gray"];
            sendLabel.ForeColor = ColorUtil.palette["peach-cream"];
            tagLabel.BackColor = ColorUtil.palette["charcoal-gray"];
            tagLabel.ForeColor = ColorUtil.palette["peach-cream"];
        }

        private void captionTextBox_Click(object sender, EventArgs e)
        {
            if (captionTextBox.Text == "Write your caption here...")
            {
                captionTextBox.Text = "";
                captionTextBox.ForeColor = Color.Black;
            }
        }

        private void captionTextBox_Leave(object sender, EventArgs e)
        {
            if (captionTextBox.Text == "")
            {
                captionTextBox.Text = "Write your caption here...";
                captionTextBox.ForeColor = ColorUtil.palette["light-grey"];
            }
        }

        private void addVideoButton_Click(object sender, EventArgs e)
        {
            if (videoPath == null)
            {
                System.Windows.Forms.OpenFileDialog fd = new System.Windows.Forms.OpenFileDialog();
                fd.Filter = "Image Files|*.mp4;";
                fd.Title = "Pilih sebuah video!";

                if (fd.ShowDialog() == DialogResult.OK)
                { 
                    addVideoButton.BackgroundImage = Properties.Resources.VideoAddedButton;
                    videoPath = fd.FileName;
                }
            } 
            else
            {
                addVideoButton.BackgroundImage = Properties.Resources.AddVideoButton;
                videoPath = null;
            }
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                System.Windows.Forms.OpenFileDialog fd = new System.Windows.Forms.OpenFileDialog();
                fd.Filter = "Image Files|*.jpeg;*.jpg;*.png;";
                fd.Title = "Pilih sebuah foto!";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string path = fd.FileName;

                    addPhotoButton.BackgroundImage = Properties.Resources.PhotoAddedButton;
                    image = Image.FromFile(path);
                }
            }
            else
            {
                addPhotoButton.BackgroundImage = Properties.Resources.AddPhotoButton;
                image = null;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string caption = !captionTextBox.Text.Equals("Write your caption here...") ? caption = captionTextBox.Text : "-";

            // Simpan foto
            string iPath = image != null ? fileRepo.StoreImage(image) : "-";

            // Simpan video
            string vPath = videoPath == null ? fileRepo.StoreVideo(videoPath) : "-";

            Konten konten = new Konten(mainForm.currentUser, caption, iPath, vPath, DateTime.Now);

            // Simpan ke database
            konten.Id = service.SaveKonten(konten);

            foreach (User u in taggedUser)
            {
                service.TagUser(konten, u);
            }

            MessageBox.Show("Berhasil menyimpan konten!");

            contentUC_P.MultipleContentUC_Load(sender, e);
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            contentUC_P.flp.Hide();
            NotificationUC uc = new NotificationUC(mainForm, contentUC_P, service);
            contentUC_P.Controls.Add(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tagButton_Click(object sender, EventArgs e)
        {
            TagUC uc = new TagUC(service, mainForm, contentUC_P, this);
            contentUC_P.flp.Hide();
            contentUC_P.Controls.Add(uc);
        }
    }
}
