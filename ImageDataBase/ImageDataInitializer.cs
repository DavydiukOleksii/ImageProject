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
    //очищує БД якщо модель змінилася
    class ImageDataInitializer: DropCreateDatabaseIfModelChanges<ImageDataContext>
    {
        //перевизначаємо метод для запису даних підчас процесу ініціалізації БД
        protected override void Seed(ImageDataContext context)
        {
            context.ImageEntitys.RemoveRange(context.ImageEntitys);

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "First image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\1.jpg")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Second image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\2.jpg")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Third image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\3.jpg")
            });
            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Fourth image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\4.jpg")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Fifth image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\5.jpg")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Sixth image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\6.jpg")
            });
            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Seventh image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\7.jpg")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Eighth image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\8.jpg")
            });

            context.ImageEntitys.Add(new ImageEntity
            {
                Description = "Ninth image.",
                Photo = ImageProvider.GetImage(@"D:\Projects\ImageTestProject\ImageDataBase\Images\9.jpg")
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
