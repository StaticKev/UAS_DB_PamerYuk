using Class_PamerYuk;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.Persistence;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public partial class SignInUC : UserControl
    {
        private readonly UserManagerService service;
        private readonly MainForm mainForm;
        private readonly FileRepo fileRepo;

        public SignInUC(UserManagerService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
            this.fileRepo = new FileRepo();
        }

        private void SignInUserControl_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
            panel_ProfilePict.BackgroundImage = Properties.Resources.DefaultProfilePict;
            panel_ProfilePict.BackgroundImageLayout = ImageLayout.Stretch;

            List<Kota> daftarKota = service.GetAllKota();
            comboBox_Kota.DataSource = daftarKota;
            comboBox_Kota.DisplayMember = "Nama";
        }

        private void label_LogIn_Click(object sender, EventArgs e)
        {
            LoginUC uc = new LoginUC(service, mainForm);
            mainForm.Controls.Add(uc);
            mainForm.Controls.Remove(this);
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox_Username.Text;
                string password = textBox_Password.Text;
                DateTime tglLahir = dateTimePicker_TglLahir.Value;
                string noKtp = textBox_NomorKTP.Text;
                Kota kota = comboBox_Kota.SelectedItem as Kota;
                string path = fileRepo.StoreImage(panel_ProfilePict.BackgroundImage); // Menyimpan gambar ke File Storage

                User user = new User(username, password, tglLahir, noKtp, path, kota);
                service.RegisterUser(user);

                MessageBox.Show("Success!");

                LoginUC uc = new LoginUC(service, mainForm);
                mainForm.Controls.Add(uc);
                mainForm.Controls.Remove(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label_changePicture_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new System.Windows.Forms.OpenFileDialog();
            fd.Filter = "Image Files|*.jpeg;*.jpg;*.png;";
            fd.Title = "Pilih sebuah gambar!";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.FileName;

                panel_ProfilePict.BackgroundImage = Image.FromFile(path);
            }
        }
    }
}
