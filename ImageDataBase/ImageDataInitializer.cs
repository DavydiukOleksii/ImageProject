using System;
using System.Data.Entity;
using System.IO;
using System.Web;
using ImageData.Entitys;
using ImageData.Metods;

namespace ImageData
{
    //delete DB always
    class ImageDataInitializer: DropCreateDatabaseAlways<ImageDataContext>
    {
        //Overrides method for recording data during the initialization of the database
        protected override void Seed(ImageDataContext context)
        {
            context.ImageEntitys.RemoveRange(context.ImageEntitys);

            try
            {
                // Only get files that begin with the format .jpg
                string[] dirs = Directory.GetFiles(HttpContext.Current.Server.MapPath("~/Images/"), "*.jpg");

                foreach (string dir in dirs)
                {
                    context.ImageEntitys.Add(new ImageEntity
                    {
                        Description = String.Format("Image " + dir.Substring(dir.LastIndexOf('\\') + 1, dir.IndexOf('.') - dir.LastIndexOf('\\') - 1) + "."),
                        Photo = ImageProvider.GetImage(dir)
                    });
                }
            }
            catch (Exception e)
            {
                //add error log
                //Console.WriteLine(e.Message);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
