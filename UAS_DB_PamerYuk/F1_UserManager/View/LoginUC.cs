using Class_PamerYuk;
using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class LoginUC : UserControl
    {
        private readonly UserManagerService service;
        private readonly MainForm mainForm;

        public LoginUC(UserManagerService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
        }

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            SignUpUC uc = new SignUpUC(service, mainForm);
            mainForm.Controls.Add(uc);
            mainForm.Controls.Remove(this);
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(textBox_Username.Text, textBox_Password.Text);
                mainForm.currentUser = service.LogIn(user);

                mainForm.Controls.Remove(this);
                mainForm.mainPanel.Show();
                mainForm.navigationBar.Show();

                // Simpan informasi login jika diinginkan
            } 
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
