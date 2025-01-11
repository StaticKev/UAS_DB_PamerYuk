using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager.View;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F4_Content.View
{
    public partial class TagUC : UserControl
    {
        private readonly ContentService service;
        private readonly MainForm mainForm;
        private readonly HomeMenuUC homeMenu;
        private readonly ContentUC_P contentUC;

        private List<User> listUser;

        public TagUC(ContentService service, MainForm mainForm, ContentUC_P contentUC_P, HomeMenuUC homeMenuUC)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
            this.homeMenu = homeMenuUC;
            this.contentUC = contentUC_P;
        }

        private void TagUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];

            listUser = service.GetFriends(mainForm.currentUser);

            foreach (User item in listUser)
            {
                SingleTagUC uc = new SingleTagUC(item, mainForm, service, contentUC, homeMenu);
                flp.Controls.Add(uc);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            contentUC.Controls.Remove(this);
            contentUC.flp.Show();
        }
    }
}