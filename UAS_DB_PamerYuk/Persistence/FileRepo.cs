using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UAS_DB_PamerYuk.Persistence
{

    public class FileRepo
    {
        private readonly string fileStoragePath = @"..\\..\\Persistence\\FileStorage";

        public string StoreImage(Image image) 
        {
            string fullPath = "";

            if (image == null) throw new ArgumentNullException("Class: FileRepo | Image can't be null!");
            string extension = image.RawFormat.Equals(ImageFormat.Png) ? ".png" :
                               image.RawFormat.Equals(ImageFormat.Jpeg) ? ".jpeg" : ".jpg";

            if (Directory.Exists(fileStoragePath))
            {
                fullPath = GenerateFileName(fileStoragePath, extension);
                image.Save(fullPath);
            }
            else throw new DirectoryNotFoundException(fileStoragePath);

            return fullPath;
        }

        public void StoreVideo() { }

        private string GenerateFileName(string folderPath, string extension) 
        {
            int fileCount = Directory.GetFiles(folderPath).Length;

            return folderPath + @"\\FL" + fileCount.ToString().PadLeft(3, '0') + extension;
        }
    }
}
