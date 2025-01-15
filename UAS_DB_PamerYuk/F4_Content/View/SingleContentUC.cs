using Class_PamerYuk;
using System;
using System.Drawing;
using System.Windows.Forms;
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
                usernameLabel.Text = konten.User.Username;
                pPictPanel.BackgroundImage = fileRepo.RetrieveImage(konten.User.Foto);

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
