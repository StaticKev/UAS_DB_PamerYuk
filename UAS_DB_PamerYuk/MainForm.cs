using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F2_Friendship.View;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.F3_Chat.View;
using UAS_DB_PamerYuk.F4_Content;
using UAS_DB_PamerYuk.F4_Content.View;
using UAS_DB_PamerYuk.Persistence;

namespace UAS_DB_PamerYuk
{
    public partial class MainForm : Form
    {
        public User currentUser = null; 
        public Dictionary<string, User> userLoggedIn = new Dictionary<string, User>(); 

        private readonly Connection connection;
        private Control currentMenu;

        public MainForm(Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            currentMenu = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // ============================== LAST LOGIN ============================================================
/*            currentUser = ClientRepo.GetCurrentUser();

            if (currentUser == null)
            {
                mainPanel.Hide();
                navigationBar.Hide();

                UserManagerService umService = new UserManagerService(connection);
                LoginUC loginUc = new LoginUC(umService, this);
                Controls.Add(loginUc);
            }

            userLoggedIn = ClientRepo.GetAllUserLoggedIn();

            ContentService cService = new ContentService(connection);
            ContentUC_P contentUc = new ContentUC_P(cService, this);

            currentMenu = contentUc;
            mainPanel.Controls.Add(contentUc);*/
            // ============================== LAST LOGIN ============================================================
            // ============================== REPLACE LATER =========================================================
            mainPanel.Hide();
            navigationBar.Hide();

            UserManagerService umService = new UserManagerService(connection);
            LoginUC loginUc = new LoginUC(umService, this);
            Controls.Add(loginUc);

            ContentService cService = new ContentService(connection);
            ContentUC_P contentUc = new ContentUC_P(cService, this);

            currentMenu = contentUc;
            mainPanel.Controls.Add(contentUc);
            // ============================== REPLACE LATER =========================================================

        }

        private void HomeButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is ContentUC_P) return;

            homeButton.Image = Properties.Resources.HomeButton_clicked;
            ResetButton();

            ContentService service = new ContentService(connection);
            ContentUC_P uc = new ContentUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void SearchButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is SearchUC_P) return;

            searchButton.Image = Properties.Resources.SearchButton_clicked;
            ResetButton();

            FriendshipService service = new FriendshipService(connection);
            SearchUC_P uc = new SearchUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void ChatButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is ChatListUC_P) return;

            chatButton.Image = Properties.Resources.ChatButton_clicked;
            ResetButton();

            ChatService service = new ChatService(connection);
            ChatListUC_P uc = new ChatListUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void ProfileButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is ProfileUC_P) return;

            profileButton.Image = Properties.Resources.ProfileButton_clicked;
            ResetButton();

            UserManagerService service = new UserManagerService(connection);
            ProfileUC_P uc = new ProfileUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.Image = Properties.Resources.HomeButton_clicked;
        }

        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.Image = Properties.Resources.SearchButton_clicked;
        }

        private void ChatButton_MouseEnter(object sender, EventArgs e)
        {
            chatButton.Image = Properties.Resources.ChatButton_clicked;
        }

        private void ProfileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.Image = Properties.Resources.ProfileButton_clicked;
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is ContentUC_P)) homeButton.Image = Properties.Resources.HomeButton;
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is SearchUC_P)) searchButton.Image = Properties.Resources.SearchButton;
        }

        private void ChatButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is ChatListUC_P)) chatButton.Image = Properties.Resources.ChatButton;
        }

        private void ProfileButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is ProfileUC_P)) profileButton.Image = Properties.Resources.ProfileButton;
        }

        private void ResetButton()
        {
            if (currentMenu is ContentUC_P) homeButton.Image = Properties.Resources.HomeButton;
            else if (currentMenu is SearchUC_P) searchButton.Image = Properties.Resources.SearchButton;
            else if (currentMenu is ChatListUC_P) chatButton.Image = Properties.Resources.ChatButton;
            else if (currentMenu is ProfileUC_P) profileButton.Image = Properties.Resources.ProfileButton;
        }
    }
}
