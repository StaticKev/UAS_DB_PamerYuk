using System;
using System.Configuration;

namespace Class_PamerYuk
{
    public class Percakapan
    {
        #region Data Member
        private int id;
        private User pengirim;
        private User penerima;
        private string pesan;
        private DateTime waktuKirim;
        #endregion

        #region Constructor
        public Percakapan(string pesan, DateTime waktuKirim, User pengirim, User penerima)
        {
            Pesan = pesan;
            WaktuKirim = waktuKirim;
            Pengirim = pengirim;
            Penerima = penerima;
        }
        #endregion

        #region Property
        public int Id
        {
            get => id;
            private set
            {
                if (value < 1) throw new ArgumentException("Class: Konten | Id must be greater than 0!");
                else id = value;
            }
        }
        public User Pengirim
        {
            get => pengirim;
            set
            {
                if (value == null) throw new ArgumentNullException("Class: Percakapan | Pengirim can't be null!");
                else pengirim = value;
            }
        }
        public User Penerima
        {
            get => penerima;
            set
            {
                if (value == null) throw new ArgumentNullException("Class: Percakapan | Penerima can't be null!");
                else penerima = value;
            }
        }
        public string Pesan 
        { 
            get => pesan; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Percakapan | Pesan can't be null");
                else pesan = value;
            } 
        }
        public DateTime WaktuKirim 
        { 
            get => waktuKirim; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Percakapan | WaktuKirim can't be null!");
                else if (value.CompareTo(DateTime.Now) > 0) throw new ArgumentException("Class: Percakapan | WaktuKirim must be greater than the current time!");
                else waktuKirim = value;
            } 
        }
        #endregion
    }
}
