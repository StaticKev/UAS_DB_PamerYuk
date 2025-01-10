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

    public partial class ListKisahHidup : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AccountUC_P accountUC;
        private readonly UserManagerService service;

        private readonly List<KisahHidup> kisahHidupUser;

        public ListKisahHidup(MainForm mainForm, AccountUC_P accountUC, UserManagerService service)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.accountUC = accountUC;
            this.service = service;

            kisahHidupUser = service.GetKisahHidup(mainForm.currentUser);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            accountUC.Controls.Remove(this);
            accountUC.panel_profile.Show();
            accountUC.flp_content.Show();
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (KisahHidup item in kisahHidupUser)
                {
                    Organisasi o = (Organisasi) comboBox_Organisasi.SelectedItem;
                    if (item.Organisasi.Id == o.Id) throw new Exception("Organisasi hidup sudah digunakan!");
                }

                KisahHidup kh = new KisahHidup(
                    (Organisasi)comboBox_Organisasi.SelectedItem,
                    mainForm.currentUser,
                    textBox_ThAwal.Text,
                    textBox_ThAkhir.Text,
                    textBox_Caption.Text);

                service.AddKisahHidup(kh);
                MessageBox.Show("Berhasil menambah kisah hidup baru!");

                ListKisahHidup_Load(sender, e);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListKisahHidup_Load(object sender, EventArgs e)
        {
            flp.Controls.Clear();

            comboBox_Organisasi.DataSource = service.GetAllOrganisasi();
            comboBox_Organisasi.DisplayMember = "Nama";

            foreach(KisahHidup kh in kisahHidupUser)
            {
                flp.Controls.Add(new SingleKisahHidupUC(kh));
            }
        }

        private void button_TambahOrganisasi_Click(object sender, EventArgs e)
        {
            accountUC.Controls.Remove(this);

            TambahOrganisasiUC uc = new TambahOrganisasiUC(mainForm, accountUC, service);
            accountUC.Controls.Add(uc);
        }
    }
}
