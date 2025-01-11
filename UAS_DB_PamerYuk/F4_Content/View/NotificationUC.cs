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
using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class NotificationUC : UserControl
    {
        private readonly MainForm mainForm;
        private readonly ContentService service;
        private readonly ContentUC_P contentUC_P;

        public NotificationUC(MainForm mainForm, ContentUC_P contentUC_P, ContentService service)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.service = service;
            this.contentUC_P = contentUC_P;
        }

        private void NotificationUC_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainForm.mainPanel.Controls.Remove(contentUC_P);
            mainForm.mainPanel.Controls.Add(new ContentUC_P(service, mainForm));
        }

        public void NotificationUC_Load_1(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            foreach (User u in service.RetrieveFriendReq(mainForm.currentUser))
            {
                flp.Controls.Add(new SingleUserRequestUC(u, mainForm, this, service));
            }
        }
    }
}
