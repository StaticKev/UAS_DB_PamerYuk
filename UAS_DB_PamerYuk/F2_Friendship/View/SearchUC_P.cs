using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F4_Content;
using UAS_DB_PamerYuk.Utility;

namespace UAS_DB_PamerYuk.F2_Friendship.View
{
    public partial class SearchUC_P : UserControl
    {
        private readonly FriendshipService service;
        private readonly MainForm mainForm;

        public SearchUC_P(FriendshipService service, MainForm mainForm)
        {
            InitializeComponent();
            this.service = service;
            this.mainForm = mainForm;
        }

        private void SearchUC_Load(object sender, EventArgs e)
        {
            BackColor = ColorUtil.palette["soft-white"];
        }

        private void buttonPencarian_Click(object sender, EventArgs e)
        {
            // Bersihkan DataGridView sebelum menambahkan data baru
            dataGridViewPencarian.Rows.Clear();

            string namaOrganisasi = textBoxPencarian.Text;

            if (string.IsNullOrEmpty(namaOrganisasi))
            {
                MessageBox.Show("Masukkan nama organisasi terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ========================================================================================
                List<Organisasi> listOrganisasi = service.GetOrganizations();
                // List<User> userByUsername = service.FindUserByUsername(new User(<Ini diganti teks dari textbox>, "-"), mainForm.currentUser);
                // List<User> userByNamaOrganisasi = service.FindUserByOrganisasi(<DIGANTI OBJEK ORGANISASI>, mainForm.currentUser);
                // ========================================================================================

                // Jalankan logika CariTeman
                List<User> users = new List<User>(); // Inisialisasi daftar user jika diperlukan
/*                var temanList = User.BacaDaftarTeman(users, namaOrganisasi);

                if (temanList.Count == 0)
                {
                    MessageBox.Show("Tidak ada teman ditemukan di organisasi tersebut.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Tambahkan hasil pencarian ke DataGridView
                    foreach (var teman in temanList)
                    {
                        teman.bacaKisahHidupOrganisasi(namaOrganisasi, out string TahunAwal, out string TahunAkkhir);
                        dataGridViewPencarian.Rows.Add(teman.Foto, teman.Username, TahunAwal, TahunAkkhir);
                    }
                }*/
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error lengkap
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPencarian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPencarian.Columns["Invite"].Index && e.RowIndex >= 0)
            {
                int friendId = int.Parse(dataGridViewPencarian.Rows[e.RowIndex].Cells["id"].Value.ToString());
                KirimUndangan(friendId);
            }
        }
        private void KirimUndangan(int friendId)
        {
            MessageBox.Show($"Permintaan pertemanan dikirim ke user ID {friendId}.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
