using Class_PamerYuk;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
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


        public SingleContentUC(ContentService service, Panel panel, Konten konten)
        {
            InitializeComponent();
            this.service = service;
            this.panel = panel;
            this.konten = konten;
            fileRepo = new FileRepo();
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
                label_caption.Text = konten.Caption;
                usernameLabel.Text = konten.User.Username;
                // pPictPanel.BackgroundImage = fileRepo.RetrieveImage(konten.User.Foto);
                // contentPictBox.BackgroundImage = fileRepo.RetrieveImage(konten.Foto);
            }

            int descHeight = TextRenderer.MeasureText(label_caption.Text, label_caption.Font).Height * ((label_caption.Text.Length / 70 + 1));
            label_caption.Size = new Size(350, descHeight);

            int postedOnPositionY = label_caption.Location.Y + label_caption.Size.Height + 6;
            label_postedOn.Location = new Point(label_postedOn.Location.X, postedOnPositionY);

            panel.Size = new Size(panel.Size.Width, panel.Size.Height + descHeight - 1);
            this.Size = new Size(this.Size.Width, this.Size.Height + descHeight - 1);

            // ============================== ADAPTIVE LAYOUT ============================================================
            /*            int deltaHeight_contentPictBox = 0;
                        Image image = Properties.Resources.AddContentButton; // Image dari konten

                        // Memunculkan icon video jika konten mengandung video
                        if (konten.Video == null) ;
                        else;

                        // Menentukan perubahan rasio picture box
                        if (konten.Foto == null) deltaHeight_contentPictBox = -contentPictBox.Size.Height;
                        else
                        {
                            if (image.Size.Width / image.Size.Height != contentPictBox.Size.Width / contentPictBox.Size.Height)
                            {
                                int desiredHeight = image.Size.Height * contentPictBox.Width / image.Size.Width;
                                deltaHeight_contentPictBox = desiredHeight - contentPictBox.Height;
                            }
                        }

                        int descHeight = 0;

                        if (label_caption.Text.Length != 0)
                        {
                            // Menghitung tinggi caption
                            descHeight = TextRenderer.MeasureText(label_caption.Text, label_caption.Font).Height * ((label_caption.Text.Length / 70 + 1));
                            label_caption.Size = new Size(350, descHeight);

                            // Mengubah posisi waktu posting (relatif terhadap tinggi caption)
                            int postedOnPositionY = label_caption.Location.Y + label_caption.Size.Height + 6;
                            label_postedOn.Location = new Point(label_postedOn.Location.X, postedOnPositionY);
                        }

                        // Teks kosong, gambar kosong, 2 2 nya ada

                        // Mengubah ukuran panel dan posisi semua elemen di bawah PictBox
                        panel.Size = new Size(panel.Size.Width, panel.Size.Height + descHeight - 1 + deltaHeight_contentPictBox);
                        this.Size = new Size(this.Size.Width, this.Size.Height + descHeight - 1 + deltaHeight_contentPictBox);
                        likeButton.Location = new Point(likeButton.Location.X, likeButton.Location.Y + deltaHeight_contentPictBox);
                        commentButton.Location = new Point(commentButton.Location.X, commentButton.Location.Y + deltaHeight_contentPictBox);
                        label_caption.Location = new Point(label_caption.Location.X, label_caption.Location.Y + deltaHeight_contentPictBox);
                        label_postedOn.Location = new Point(label_postedOn.Location.X, label_postedOn.Location.Y + deltaHeight_contentPictBox);*/
            // ============================== ADAPTIVE LAYOUT ============================================================
        }

        private void On_MouseClick(object sender, MouseEventArgs e)
        {

        }

        // TEST PURPOSE ONLY!
        public void setTestSample(int index)
        {
            if (index == 2)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser2;
                contentPictBox.Image = Properties.Resources.sampleContent2;
                usernameLabel.Text = "eunwo.o_c";
                label_caption.Text = "With the soft patter of rain against the window, they settled into their favorite chair, " +
                    "cradling a freshly made egg mayo sandwich. The creamy blend of eggs and mayonnaise, nestled between " +
                    "perfectly toasted bread, felt like the ultimate comfort on this gray afternoon. Outside, the rain " +
                    "painted the world in hues of silver and green, each droplet a tiny symphony on the glass. As they took " +
                    "a bite, the richness of the sandwich harmonized with the calming rhythm of the storm. The air smelled " +
                    "of rain-soaked earth, mingling with the warmth of the kitchen—a perfect pairing. Sometimes, the " +
                    "simplest pleasures, like a good sandwich and a rainy day, create the most unforgettable moments.";
            } else if (index == 3)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser4;
                contentPictBox.Image = Properties.Resources.sampleContent4;
                usernameLabel.Text = "skuukzky";
                label_caption.Text = "...";
            } else if (index == 4)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser5;
                contentPictBox.Image = Properties.Resources.sampleContent3;
                usernameLabel.Text = "xeesoxee";
                label_caption.Text = "Embracing the summer vibes through the day!";
            } else if (index == 5)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser3;
                contentPictBox.Image = Properties.Resources.sampleContent5;
                usernameLabel.Text = "donlee";
                label_caption.Text = "After a midnight showdown.";
            }
        }
    }
}
