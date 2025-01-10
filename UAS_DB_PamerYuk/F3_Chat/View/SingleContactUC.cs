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
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class SingleContactUC : UserControl
    {
        public readonly ChatService service;
        public readonly MainForm mainForm;
        public readonly ChatListUC_P chatListUC;
        private readonly FileRepo fileRepo;
        public readonly User user;

        public SingleContactUC(User user, ChatService service, MainForm mainForm, ChatListUC_P chatListUC)
        {
            InitializeComponent();
            this.service = service;
            this.chatListUC = chatListUC;
            this.user = user;
            this.mainForm = mainForm;
            fileRepo = new FileRepo();
        }

        private void SingleContactUC_MouseClick(object sender, MouseEventArgs e)
        {
            ChatRoomUC load = new ChatRoomUC(user, service, chatListUC, mainForm);
            chatListUC.flp.Visible = false;
            chatListUC.lblHeaderChat.Visible = false;
            chatListUC.Controls.Add(load);
        }

        private void SingleContactUC_Load(object sender, EventArgs e)
        {
            pPictPanel.BackgroundImage = fileRepo.RetrieveImage(user.Foto);
            label_Username.Text = user.Username;
        }
    }
}
