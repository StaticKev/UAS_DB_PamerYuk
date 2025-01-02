using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatRoomUC : UserControl
    {
        private readonly ChatService service;
        private readonly ChatListUC_P chatListUc;

        public ChatRoomUC(ChatService service, ChatListUC_P chatListUc)
        {
            InitializeComponent();
            this.service = service;
            this.chatListUc = chatListUc;
        }

        private void ChatRoomUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
            chatListUc.textBox_Search.Visible = false;
            chatListUc.lblHeaderChat.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            chatListUc.Controls.Remove(this);
            chatListUc.textBox_Search.Visible = true;
            chatListUc.lblHeaderChat.Visible = true;
            chatListUc.Controls[2].Visible = true;
        }
    }
}
