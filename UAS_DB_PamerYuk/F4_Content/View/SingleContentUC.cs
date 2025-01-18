using Class_PamerYuk;
using System;
using System.Drawing;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.Persistence;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class SingleContentUC : UserControl
    {
        private readonly ContentService service;
        private readonly Panel panel;
        private readonly Konten konten;
        private readonly FileRepo fileRepo;
        private readonly ContentUC_P contentUC;
        private readonly AccountUC_P accountUC;
        private readonly MainForm mainForm;

        public SingleContentUC(ContentService service, Panel panel, Konten konten, ContentUC_P contentUC, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.panel = panel;
            this.konten = konten;
            fileRepo = new FileRepo();
            this.contentUC = contentUC;
            this.mainForm = mainForm;
        }

        public SingleContentUC(ContentService service, Panel panel, Konten konten, AccountUC_P accountUC, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.panel = panel;
            this.konten = konten;
            fileRepo = new FileRepo();
            this.accountUC = accountUC;
            this.mainForm = mainForm;
        }

        // TEST PURPOSE ONLY!
        public SingleContentUC(ContentService service, Panel panel)
        {
            InitializeComponent();
            this.service = service;
            this.panel = panel;
        }

        private void SingleContentUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];

            if (konten != null)
            {
                usernameLabel.Text = konten.User.Username;
                pPictPanel.BackgroundImage = fileRepo.RetrieveImage(konten.User.Foto);

                // Mengecek like
                if (service.UserLikes(konten, mainForm.currentUser))
                {
                    likeButton.BackgroundImage = Properties.Resources.LikeButton_Clicked;
                }
                else
                {
                    likeButton.BackgroundImage = Properties.Resources.LikeButton;
                }

                if (konten.Video.Equals("-")) videoButton.Hide();

                // Memindahkan control berdasarkan ada tidaknya caption
                if (!konten.Caption.Equals("-"))
                {
                    label_caption.Text = konten.Caption;

                    int descHeight = TextRenderer.MeasureText(label_caption.Text, label_caption.Font).Height * ((label_caption.Text.Length / 70 + 1));
                    label_caption.Size = new Size(350, descHeight);

                    panel.Size = new Size(panel.Size.Width, panel.Size.Height + descHeight - 1);
                    this.Size = new Size(this.Size.Width, this.Size.Height + descHeight - 1);

                    int postedOnPositionY = label_caption.Location.Y + label_caption.Size.Height + 6;
                    label_postedOn.Location = new Point(label_postedOn.Location.X, postedOnPositionY);
                }

                // Memindahkan control berdasarkan ada tidaknya gambar
                if (!konten.Foto.Equals("-")) contentPictBox.Image = fileRepo.RetrieveImage(konten.Foto);
                else
                {
                    contentPictBox.Hide();
                    panel.Size = new Size(panel.Size.Width, panel.Size.Height - contentPictBox.Height);
                    this.Size = new Size(this.Size.Width, this.Size.Height - contentPictBox.Height);
                    label_caption.Location = new Point(label_caption.Location.X, label_caption.Location.Y - contentPictBox.Height);
                    likeButton.Location = new Point(likeButton.Location.X, likeButton.Location.Y - contentPictBox.Height);
                    commentButton.Location = new Point(commentButton.Location.X, commentButton.Location.Y - contentPictBox.Height);
                    label_postedOn.Location = new Point(label_postedOn.Location.X, label_postedOn.Location.Y - contentPictBox.Height);
                }

                // Memindahkan control berdasarkan rasio gambar
                if (!konten.Foto.Equals("-"))
                {
                    Image image = fileRepo.RetrieveImage(konten.Foto); // Image dari konten
                    Console.WriteLine($"{image.Size.Width} / {image.Size.Height} === {contentPictBox.Size.Width} / {contentPictBox.Size.Height}");

                    double actualRatio = (double) image.Size.Width / image.Size.Height;
                    double pictBoxRatio = (double) contentPictBox.Size.Width / contentPictBox.Size.Height;

                    if (actualRatio != pictBoxRatio)
                    {
                        int pictBox_DeltaH = 0;

                        // Menghitung perubahan tinggi akibat penyesuaian rasio gambar
                        int desiredHeight = image.Size.Height * contentPictBox.Width / image.Size.Width;
                        pictBox_DeltaH = desiredHeight - contentPictBox.Height;
                        Console.WriteLine($"{konten.Id} -> {pictBox_DeltaH}");

                        contentPictBox.Size = new Size(contentPictBox.Size.Width, contentPictBox.Size.Height + pictBox_DeltaH);
                        label_caption.Location = new Point(label_caption.Location.X, label_caption.Location.Y + pictBox_DeltaH);
                        likeButton.Location = new Point(likeButton.Location.X, likeButton.Location.Y + pictBox_DeltaH);
                        commentButton.Location = new Point(commentButton.Location.X, commentButton.Location.Y + pictBox_DeltaH);
                        label_postedOn.Location = new Point(label_postedOn.Location.X, label_postedOn.Location.Y + pictBox_DeltaH);

                        if (pictBox_DeltaH > 0)
                        {
                            panel.Size = new Size(panel.Size.Width, panel.Size.Height + pictBox_DeltaH);
                            this.Size = new Size(panel.Size.Width, panel.Size.Height + pictBox_DeltaH);
                        }
                    }
                }
            }
        }

        private void On_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            if (contentUC != null)
            {
                CommentUC commentUC = new CommentUC(mainForm, contentUC, konten, service);
                contentUC.Controls.Add(commentUC);
                contentUC.flp.Hide();
            } else
            {
                CommentUC commentUC = new CommentUC(mainForm, accountUC, konten, service);
                accountUC.Controls.Add(commentUC);
                accountUC.flp_content.Hide();
                accountUC.panel_profile.Hide();
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            if (service.UserLikes(konten, mainForm.currentUser))
            {
                likeButton.BackgroundImage = Properties.Resources.LikeButton;
                service.DislikeContent(konten, mainForm.currentUser);
            } 
            else
            {
                likeButton.BackgroundImage = Properties.Resources.LikeButton_Clicked;
                service.LikeContent(konten, mainForm.currentUser);
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            if (contentUC != null)
            {
                OverviewUserControl uc = new OverviewUserControl(contentUC, service, konten);
                contentUC.flp.Hide();
                contentUC.Controls.Add(uc);
            }
            else
            {
                OverviewUserControl uc = new OverviewUserControl(accountUC, service, konten);
                accountUC.flp_content.Hide();
                accountUC.panel_profile.Hide();
                accountUC.Controls.Add(uc);
            }
        }
    }
}
