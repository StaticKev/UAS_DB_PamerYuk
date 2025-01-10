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

namespace UAS_DB_PamerYuk.F1_UserManager.View
{
    public partial class SingleKisahHidupUC : UserControl
    {
        private readonly KisahHidup kisahHidup;

        public SingleKisahHidupUC(KisahHidup kisahHidup)
        {
            InitializeComponent();
            this.kisahHidup = kisahHidup;
        }

        private void SingleKisahHidupUC_Load(object sender, EventArgs e)
        {
            label_Organisasi.Text = kisahHidup.Organisasi.Nama;
            label_TahunAkhir.Text = kisahHidup.Thakhir;
            label_TahunAwal.Text = kisahHidup.Thawal;
            label_Kota.Text = kisahHidup.Organisasi.Kota.Nama;
            label_Deskripsi.Text = kisahHidup.Deskripsi;

            int descHeight = TextRenderer.MeasureText(label_Deskripsi.Text, label_Deskripsi.Font).Height * ((label_Deskripsi.Text.Length / 70 + 1));
            label_Deskripsi.Size = new Size(350, descHeight);

            this.Size = new Size(this.Size.Width, this.Size.Height + descHeight - 1);
        }
    }
}
