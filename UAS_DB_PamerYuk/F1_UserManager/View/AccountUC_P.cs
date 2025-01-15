using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager.View;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.F4_Content.View;
using UAS_DB_PamerYuk.Repository.DAO;
using UAS_DB_PamerYuk.Utility;
using static System.Net.WebRequestMethods;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class AccountUC_P : UserControl
    {
        private readonly UserManagerService userManagerService;
        private readonly ContentService contentService;
        private readonly MainForm mainForm;

        private readonly KontenDAO kontenDAO;

        public AccountUC_P(UserManagerService userManagerService, ContentService contentService, MainForm mainForm)
        {
            InitializeComponent();
            this.userManagerService = userManagerService;
            this.contentService = contentService;
            this.mainForm = mainForm;

            this.kontenDAO = new KontenDAO(new Connection());
        }

        private void ProfileUserControl_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];

            ProfileUC profileUC = new ProfileUC(mainForm, this, userManagerService);
            panel_profile.Controls.Add(profileUC);

            List<Konten> listKonten = kontenDAO.Read_Content(mainForm.currentUser, KontenDAO.OwnedBy.CURRENT_USER);
            foreach (Konten k in listKonten)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(0)
                };

                SingleContentUC scu = new SingleContentUC(contentService, panel, k, this, mainForm);
                panel.SetBounds(0, 0, scu.Size.Width, scu.Size.Height);
                panel.Controls.Add(scu);

                flp_content.Controls.Add(panel);
            }
        }

        private void panel_profile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flp_content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}