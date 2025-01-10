using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager.View;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.F4_Content.View;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class AccountUC_P : UserControl
    {
        private readonly UserManagerService userManagerService;
        private readonly ContentService contentService;
        private readonly MainForm mainForm;

        public AccountUC_P(UserManagerService userManagerService, ContentService contentService, MainForm mainForm)
        {
            InitializeComponent();
            this.userManagerService = userManagerService;
            this.contentService = contentService;
            this.mainForm = mainForm;
        }

        private void ProfileUserControl_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];

            ProfileUC profileUC = new ProfileUC(mainForm, this, userManagerService);
            panel_profile.Controls.Add(profileUC);

            for (int i = 1; i <= 5; i++)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(0)
                };

                SingleContentUC scu = new SingleContentUC(contentService, panel);
                scu.setTestSample(i);
                scu.BackColor = ColorUtil.palette["soft-white"];

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