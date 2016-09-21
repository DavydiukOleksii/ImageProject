using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageData.Entitys;

namespace ImageData
{
    public class ImageDataContext: DbContext
    {
        public ImageDataContext(): base("ImageDataBase")
        {
            Database.SetInitializer<ImageDataContext>( new ImageDataInitializer());
        }

        public DbSet<ImageEntity> ImageEntitys { get; set; }
    }
}
