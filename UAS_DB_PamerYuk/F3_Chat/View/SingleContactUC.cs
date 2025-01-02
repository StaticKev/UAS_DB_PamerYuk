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

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class SingleContactUC : UserControl
    {
        public readonly ChatService service;
        public readonly ChatListUC_P chatList;

        public SingleContactUC(ChatService service, ChatListUC_P chatlist)
        {
            InitializeComponent();
            this.service = service;
            this.chatList = chatlist;
        }

        public void setTestSample(int index)
        {
            if (index % 2 == 0)
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser2;
                lblNamaKontak.Text = "kevin" + index;
            }
            else
            {
                pPictPanel.BackgroundImage = Properties.Resources.sampleUser3;
                lblNamaKontak.Text = "daniel" + index;
            }
        }

        private void SingleContactUC_MouseClick(object sender, MouseEventArgs e)
        {
            ChatRoomUC load = new ChatRoomUC(service, chatList);
            chatList.Controls.Add(load);
            chatList.Controls[2].Visible = false;
            chatList.lblHeaderChat.Visible = false;
            chatList.textBox_Search.Visible = false;
        }
    }
}
