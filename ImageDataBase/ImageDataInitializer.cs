using ImageData.Entitys;
using ImageData.Metods;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageData
{
    class ImageDataInitializer: DropCreateDatabaseIfModelChanges<ImageDataContext>
    {
        protected override void Seed(ImageDataContext context)
        {
            context.ImageEntitys.RemoveRange(context.ImageEntitys);

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "First image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageModel\Image\images.png")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Second image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageModel\Image\smile.png")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Third image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageModel\Image\smile2.png")
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
