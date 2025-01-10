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
using UAS_DB_PamerYuk.F3_Chat;

namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    public partial class TambahOrganisasiUC : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AccountUC_P accountUC;
        private readonly UserManagerService service;

        public TambahOrganisasiUC(MainForm mainForm, AccountUC_P accountUC, UserManagerService service)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.accountUC = accountUC;
            this.service = service;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            try
            {
                Organisasi o = new Organisasi(100, textBox_Nama.Text, (Kota)comboBox_Kota.SelectedItem);
                service.AddOrganisasi(o);

                MessageBox.Show("Organisasi berhasil ditambahkan!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TambahOrganisasiUC_Load(object sender, EventArgs e)
        {
            comboBox_Kota.DataSource = service.GetAllKota();
            comboBox_Kota.DisplayMember = "Nama";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            accountUC.Controls.Remove(this);
            accountUC.Controls.Add(new ListKisahHidup(mainForm, accountUC, service));
        }
    }
}
