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
    public partial class CommentUC : UserControl
    {
        private readonly MainForm mainForm;
        private readonly ContentUC_P contentUC;
        private readonly Konten konten;
        private readonly ContentService service;
        private readonly AccountUC_P accountUC;

        public CommentUC(MainForm mainForm, ContentUC_P contentUC, Konten konten, ContentService service)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.contentUC = contentUC;
            this.konten = konten;
            this.service = service;
        }

        public CommentUC(MainForm mainForm, AccountUC_P accountUC, Konten konten, ContentService service)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.konten = konten;
            this.service = service;
            this.accountUC = accountUC;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Komen komen = new Komen(textBox1.Text, DateTime.Now, mainForm.currentUser);
            service.SendComment(konten, komen);
            listBox_Comment.Items.Add($"{komen.Tgl} [{komen.User.Username}] {komen.Komentar}");
        }

        private void btnback_Click(object sender, EventArgs e)
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

        private void CommentUC_Load(object sender, EventArgs e)
        {
            List<Komen> komen = service.GetPostComments(konten);

            foreach (Komen k in komen)
            {
                listBox_Comment.Items.Add($"{k.Tgl} [{k.User.Username}] {k.Komentar}");
            }
        }
    }
}
