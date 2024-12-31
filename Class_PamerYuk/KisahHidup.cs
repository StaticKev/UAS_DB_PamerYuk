using System;

namespace Class_PamerYuk
{
    public class KisahHidup
    {
        #region Data Member
        private Organisasi organisasi;
        private User user;
        private string thawal;
        private string thakhir;
        private string deskripsi;
        #endregion

        #region Constructor
        public KisahHidup(Organisasi organisasi, User user, string thawal, string thakhir, string deskripsi)
        {
            if (thawal.CompareTo(thakhir) >= 0) throw new ArgumentException("Tahun akhir harus setelah tahun awal!");

            User = user;
            Organisasi = organisasi;
            Thawal = thawal;
            Thakhir = thakhir;
            Deskripsi = deskripsi;
        }
        #endregion

        #region Property
        public Organisasi Organisasi 
        {
            get => organisasi;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: KisahHidup | Organisasi can't be null!");
                else organisasi = value;
            }
        }
        public User User
        {
            get => user;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class Konten | User can't be null!");
                else user = value;
            }
        }
        public string Thawal 
        {
            get => thawal;
            private set
            {
                if (value == null || value == "") throw new ArgumentNullException("Class: KisahHidup | Thakhir can't be null or empty!");
                thawal = value;
            }
        }
        public string Thakhir 
        {
            get => thakhir;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: KisahHidup | Thakhir can't be null!");
                thakhir = value;
            }
        }
        public string Deskripsi 
        { 
            get => deskripsi; 
            private set
            {
                if (value == null) throw new ArgumentException("Class: KisahHidup | Deskripsi can't be null!");
                else deskripsi = value;
            }
        }

        #endregion
    }
}