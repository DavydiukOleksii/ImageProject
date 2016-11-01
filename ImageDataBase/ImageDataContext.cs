using System.Data.Entity;
using ImageData.Entitys;

namespace ImageData
{
    public class ImageDataContext: DbContext
    {
        public ImageDataContext(): base("ImgDataBase")
        {
            Database.SetInitializer<ImageDataContext>(new ImageDataInitializer());
        }

        public DbSet<ImageEntity> ImageEntitys { get; set; }
    }
}
