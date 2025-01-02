using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Persistence;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatListUC_P : UserControl
    {
        private readonly ChatService service;
        private readonly MainForm mainForm;
        private readonly FileRepo fileRepo;

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
            FlowLayoutPanel flowChatList = new FlowLayoutPanel();
            flowChatList.AutoScroll = true;

            Controls.Add(flowChatList);
            int i;

            flowChatList.Size = new System.Drawing.Size(485, (Size.Height - lblHeaderChat.Height - textBox_Search.Height));
            flowChatList.Location = new System.Drawing.Point(0, (textBox_Search.Height + lblHeaderChat.Height));
            for (i = 0; i <= 20; i++)
            {

                SingleContactUC sc = new SingleContactUC(service, this);
                sc.setTestSample(i);
                sc.BackColor = ColorUtil.palette["soft-white"];

                flowChatList.Controls.Add(sc);
            }
            textBox_Search.Visible = true;
            lblHeaderChat.Visible = true;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
