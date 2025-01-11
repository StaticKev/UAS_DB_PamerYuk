using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{

    public partial class ContentUC_P : UserControl
    {
        private readonly ContentService service;
        private readonly MainForm mainForm;

        public ContentUC_P(ContentService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        public void MultipleContentUC_Load(object sender, EventArgs e)
        {
            flp.Controls.Clear();

            Panel buttonPanel = new Panel
            {
                BorderStyle = BorderStyle.None,
                Margin = new Padding(0)
            };

            HomeMenuUC hmu = new HomeMenuUC(mainForm, this, service);
            hmu.BackColor = ColorUtil.palette["soft-white"];

            buttonPanel.SetBounds(0, 0, hmu.Size.Width, hmu.Size.Height);
            buttonPanel.Controls.Add(hmu);

            flp.Controls.Add(buttonPanel);

            List<Konten> kontenTeman = service.GetKontenTeman(mainForm.currentUser);
            foreach (Konten k in kontenTeman)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(0)
                };

                SingleContentUC scu = new SingleContentUC(service, panel, k);
                panel.SetBounds(0, 0, scu.Size.Width, scu.Size.Height);
                panel.Controls.Add(scu);

                flp.Controls.Add(panel);
            }

/*            for (int i = 1; i <= 5; i++)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(0)
                };

                SingleContentUC scu = new SingleContentUC(service, panel);
                scu.setTestSample(i);
                scu.BackColor = ColorUtil.palette["soft-white"];

                panel.SetBounds(0, 0, scu.Size.Width, scu.Size.Height);
                panel.Controls.Add(scu);

                flp.Controls.Add(panel);
            }*/
        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
