using System;

namespace Class_PamerYuk
{
    public class Konten
    {
        #region Data Member
        private int id;
        private User user;
        private string caption;
        private string foto;
        private string video;
        private DateTime tanggalUpload;
        #endregion

        #region Constructor
        public Konten(int id, User user, string caption, string foto, string video, DateTime tanggalUpload)
        {
            Id = id;
            User = user;
            Caption = caption;
            Foto = foto;
            Video = video;
            TanggalUpload = tanggalUpload;
        }
        public Konten(User user, string caption, string foto, string video, DateTime tanggalUpload)
        {
            User = user;
            Caption = caption;
            Foto = foto;
            Video = video;
            TanggalUpload = tanggalUpload;
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
        public User User
        {
            get => user;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class Konten | User can't be null!");
                else user = value;
            }
        }
        public string Caption { get => caption; private set => caption = value; }
        public string Foto { get => foto; private set => foto = value; }
        public string Video { get => video; private set => video = value; }
        public DateTime TanggalUpload 
        { 
            get => tanggalUpload;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Konten | TanggalUpload can't be null!");
                else if (value.CompareTo(DateTime.Now) > 0) throw new ArgumentException("Class: Konten | TanggalUpload can't be greater than today!");
                else tanggalUpload = value;
            }
        }
        #endregion
    }
}
