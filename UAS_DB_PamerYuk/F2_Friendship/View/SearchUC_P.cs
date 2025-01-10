using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F4_Content;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class SearchUC_P : UserControl
    {
        private readonly FriendshipService service;
        private readonly MainForm mainForm;

        public SearchUC_P(FriendshipService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void SearchUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
            comboBox_Organisasi.DataSource = service.GetOrganizations();
            comboBox_Organisasi.DisplayMember = "Nama";
            comboBox_Organisasi.SelectedIndex = -1;
        }

        public void comboBox_Organisasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            flp.Controls.Clear();

            List<User> users = null;
            Organisasi org = (Organisasi)comboBox_Organisasi.SelectedItem;
            if (org != null)
            {
                users = service.FindUserByOrganisasi(org, mainForm.currentUser);
            }

            if (users != null)
            {
                foreach (User u in users)
                {
                    flp.Controls.Add(new SingleUserRequestUC(u, mainForm, this, service));
                }
            }
        }
    }
}
