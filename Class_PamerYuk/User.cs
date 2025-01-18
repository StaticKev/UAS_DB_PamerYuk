using System;

namespace Class_PamerYuk
{
    [Serializable]
    public class User
    {
        #region Data Member
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKTP;
        private string foto;
        private Kota kota;

        private string namaLengkap;
        private string email;
        private string fotoDiri;
        #endregion

        #region Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            Username = username;
            TglLahir = tglLahir;
            NoKTP = noKTP;
            Foto = foto;
            Kota = kota;
        }

        public User(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            Username = username;
            Password = password;
            TglLahir = tglLahir;
            NoKTP = noKTP;
            Foto = foto;
            Kota = kota;
        }

        public User(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota, string namaLengkap, string email, string fotoDiri)
        {
            Username = username;
            Password = password;
            TglLahir = tglLahir;
            NoKTP = noKTP;
            Foto = foto;
            Kota = kota;

            NamaLengkap = namaLengkap;
            Email = email;
            FotoDiri = fotoDiri;
        }
        #endregion

        #region Property
        public string Username 
        { 
            get => username; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | Username can't be null!");
                else if (value == "") throw new ArgumentException("Username tidak boleh kosong!");
                else if (value.Length > 40) throw new ArgumentException("Panjang username tidak boleh melebihi 40 karakter!");
                else username = value;
            } 
        }
        public string Password
        {
            get => password;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | Password can't be null!");
                else if (value == "") throw new ArgumentException("Password tidak boleh kosong!");
                else password = value;
            }
        }
        public DateTime TglLahir 
        { 
            get => tglLahir; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | TglLahir can't be null!");
                else if (value.CompareTo(DateTime.Now) > 0) throw new ArgumentException("Tanggal lahir tidak boleh lebih dari tanggal hari ini!");
                else tglLahir = value;
            }
        }
        public string NoKTP 
        { 
            get => noKTP; 
            private set
            {

                if (value == null) throw new ArgumentNullException("Class: User | NoKTP can't be null!");
                else if (value.Length != 16) throw new ArgumentException("Panjang nomor KTP adalah 16 karakter!");
                else if (int.TryParse(value, out int t)) throw new ArgumentException("Nomor KTP hanya boleh mengandung angka!");
                else noKTP = value;
            } 
        }
        public string Foto 
        { 
            get => foto; 
            set
            {
                if (value == null || value == "") throw new ArgumentException("Class: User | Invalid value for field - foto");
                else foto = value;
            }
        }
        public Kota Kota 
        { 
            get => kota; 
            set
            {
                if (value == null) throw new ArgumentNullException("Class: User | Kota can't be null!");
                else kota = value;
            } 
        }
        public string NamaLengkap { get => namaLengkap; set => namaLengkap = value; }
        public string Email { get => email; set => email = value; }
        public string FotoDiri { get => fotoDiri; set => fotoDiri = value; }
        #endregion
    }
}
