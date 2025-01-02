using System;

// NOTE: Untuk mendapatkan ID, dapat melakukan query untuk menemukan id yang terakhir kemudian ditambah 1.

namespace Class_PamerYuk
{
    public class Komen
    {
        #region Data Member
        private int id;
        private string komentar;
        private DateTime tgl;
        private User user;
        #endregion

        #region Constructor
        public Komen(int id, string komentar, DateTime tgl, User user)
        {
            Id = id;
            Komentar = komentar;
            Tgl = tgl;
            User = user;
        }
        #endregion

        #region Property
        public int Id 
        {
            get => id;
            private set
            {
                if (value < 1) throw new ArgumentException("Class: Komen | Id must be greater than 0!");
                else id = value;
            }
        }

        public string Komentar
        {
            get => komentar;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Komen | Komentar can't be null!");
                else if (value == "") throw new ArgumentNullException("Comment can't be empty!");
                else komentar = value;
            }
        }
        public DateTime Tgl 
        { 
            get => tgl; 
            set
            {
                if (value == null) throw new ArgumentNullException("Class: Komen | Tgl can't be null!");
                else if (value.CompareTo(DateTime.Now) > 0) throw new ArgumentException("Class: Komen | Tgl must be greater than the current time!");
                tgl = value;
            }
        }
        public User User 
        { 
            get => user; 
            set
            {
                if (value == null) throw new ArgumentNullException("Class: Komen | User can't be null!");
                else user = value;
            }
        }
        #endregion
    }
}
