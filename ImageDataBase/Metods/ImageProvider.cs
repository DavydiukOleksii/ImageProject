using System.IO;

namespace ImageData.Metods
{
    public class ImageProvider
    {
        //method for downloading images to DB
        public static byte[] GetImage(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
    }
}