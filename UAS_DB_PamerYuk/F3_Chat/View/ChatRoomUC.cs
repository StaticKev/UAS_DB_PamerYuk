using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.Persistence;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F3_Chat.View
{
    public partial class ChatRoomUC : UserControl
    {
        private readonly ChatService service;
        private readonly ChatListUC_P chatListUc;
        private readonly FileRepo fileRepo;
        private readonly MainForm mainForm;

        private readonly User receiver;
        private List<Percakapan> listPercakapan;

        public ChatRoomUC(User recipient, ChatService service, ChatListUC_P chatListUc, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.chatListUc = chatListUc;
            this.receiver = recipient;
            this.mainForm = mainForm;
            fileRepo = new FileRepo();
        }

        private void ChatRoomUC_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";

            BackColor = ColorUtil.palette["soft-white"];
            chatListUc.lblHeaderChat.Visible = false;

            pPictPanel.BackgroundImage = fileRepo.RetrieveImage(receiver.Foto);
            label_Username.Text = receiver.Username;

            listPercakapan = service.RetrieveChatHistory(mainForm.currentUser, receiver);

            foreach (Percakapan p in listPercakapan)
            {
                Console.WriteLine(p.WaktuKirim);
                Console.WriteLine(p.Pengirim.Username);
                Console.WriteLine(p.Pesan);
                listBox1.Items.Add($"{p.WaktuKirim.ToString()} [{p.Pengirim.Username}] {p.Pesan}");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            chatListUc.Controls.Remove(this);
            chatListUc.lblHeaderChat.Visible = true;
            chatListUc.flp.Visible = true;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string pesan = textBox1.Text;
            Percakapan percakapan = new Percakapan(pesan, DateTime.Now, mainForm.currentUser, receiver);

            service.SendMessage(percakapan);
            ChatRoomUC_Load(sender, e);
        }
    }
}
