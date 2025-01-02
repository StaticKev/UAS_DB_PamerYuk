using System;
using System.Configuration;

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
            User = user;
            Organisasi = organisasi;
            Thawal = thawal;
            Thakhir = thakhir;
            Deskripsi = deskripsi;

            if (int.Parse(Thawal) > int.Parse(Thakhir)) throw new ArgumentException("Start year musn't be greater than the end!");
            else if (int.Parse(Thakhir) < int.Parse(Thawal)) throw new ArgumentException("End year musn't be greater than the start!");
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
                else if (!int.TryParse(value, out int temp)) throw new ArgumentException("Invalid value for start year!");
                thawal = value;
            }
        }
        public string Thakhir 
        {
            get => thakhir;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: KisahHidup | Thakhir can't be null!");
                else if (!int.TryParse(value, out int temp)) throw new ArgumentException("Invalid value for end year!");
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