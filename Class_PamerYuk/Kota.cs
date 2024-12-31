using System;

namespace Class_PamerYuk
{
    public class Kota
    {
        #region Data Member
        private int id;
        private string nama;
        #endregion

        #region Constructor
        public Kota(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Property
        public int Id 
        {
            get => id;
            private set
            {
                if (value < 1) throw new ArgumentException("Class: Kota | Id must be greater than 0!");
                else id = value;
            }
        }
        public string Nama 
        { 
            get => nama; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Kota | Nama can't be null!");
                else if (value == "") throw new ArgumentException("Class: Kota | Nama can't be empty!");
                else if (value.Length > 45) throw new ArgumentException("Class: Kota | The maximum value for Nama is 45 characters!");
                else nama = value;
            }
        }
        #endregion
    }
}
