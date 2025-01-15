using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class OverviewUserControl : UserControl
    {
        private readonly ContentUC_P contentUC;
        private readonly AccountUC_P accountUC;
        private readonly ContentService service;
        private readonly Konten konten;

        public OverviewUserControl(ContentUC_P contentUC, ContentService service, Konten konten)
        {
            InitializeComponent();
            this.contentUC = contentUC;
            this.service = service;
            this.konten = konten;
        }

        public OverviewUserControl(AccountUC_P accountUC, ContentService service, Konten konten)
        {
            InitializeComponent();
            this.accountUC = accountUC;
            this.service = service;
            this.konten = konten;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (contentUC != null)
            {
                contentUC.Controls.Remove(this);
                contentUC.flp.Show();
            }
            else
            {
                accountUC.Controls.Remove(this);
                accountUC.flp_content.Show();
                accountUC.panel_profile.Show();
            }
        }

        private void OverviewUserControl_Load(object sender, EventArgs e)
        {
            List<User> like = service.RetrievePostLike(konten);
            List<User> tag = service.RetrievePostTag(konten);

            foreach (User u1 in like)
            {
                listBox_Like.Items.Add(u1.Username);
            } 
            foreach (User u2 in tag)
            {
                listBox_Comment.Items.Add(u2.Username);
            }
        }
    }
}
