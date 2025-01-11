using System;
using System.Drawing;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F2_Friendship.View;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class HomeMenuUC : UserControl
    {
        private readonly MainForm mainForm;
        private ContentUC_P contentUC_P;
        private readonly ContentService service;

        private bool isTyping;
        private string description;
        private Image image;
        private string videoPath;

        public HomeMenuUC(MainForm mainForm, ContentUC_P contentUC_P, ContentService service)
        {
            InitializeComponent();
            isTyping = false;
            this.mainForm = mainForm;
            this.contentUC_P = contentUC_P;
            this.service = service;
        }

        private void HomeMenuUC_Load(object sender, EventArgs e)
        {
            captionTextBox.BackColor = ColorUtil.palette["dim-white"];
            this.ActiveControl = notificationButton;
            sendLabel.BackColor = ColorUtil.palette["charcoal-gray"];
            sendLabel.ForeColor = ColorUtil.palette["peach-cream"];
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
            // Membuka file explorer
            // Mengganti Icon
            // Simpan path ke variabel
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            // Membuka file explorer
            // Memilih foto 
            // Mengganti icon
            // Simpan ke variabel
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // Jika tiga-tiganya kosong, berarti tidak boleh disimpan.
            // Mengecek isi dari setiap variabel, yang ada isinya disimpan.
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            // Membuka tampilan friend request
            contentUC_P.flp.Hide();
            NotificationUC uc = new NotificationUC(mainForm, contentUC_P, service);
            contentUC_P.Controls.Add(uc);
        }
    }
}
