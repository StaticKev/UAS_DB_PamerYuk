using System;
using System.Windows.Forms;
using System.Collections.Generic;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Persistence;
using UAS_DB_PamerYuk.Utility;
using Class_PamerYuk;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatListUC_P : UserControl
    {
        private readonly ChatService service;
        private readonly MainForm mainForm;
        private readonly FileRepo fileRepo;
        private List<User> listUser;

        public ChatListUC_P(ChatService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
            this.fileRepo = new FileRepo();
        }

        private void ChatListUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
            int i;

            listUser = service.GetFriend(mainForm.currentUser);

            foreach (User u in listUser)
            {
                SingleContactUC sc = new SingleContactUC(u, service, mainForm, this);
                sc.BackColor = ColorUtil.palette["soft-white"];
                flp.Controls.Add(sc);
            }

            lblHeaderChat.Visible = true;
        }
    }
}
