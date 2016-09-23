using DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageData;

namespace DataRepository
{
    public class ImageRepository: IRepository<ImageViewModel>
    {
        #region Singleton
        protected static ImageRepository instance = null; 
        public static ImageRepository Instance 
        { 
            get 
           { 
                if (instance == null) 
                    instance = new ImageRepository(); 
                return instance; 
            } 
        }         
        #endregion 

        #region Constructor
        protected ImageRepository() { }
        #endregion

        #region PublicMetods

        public List<ImageViewModel> GetAll()
        {
            using(ImageDataContext context = new ImageDataContext())
            {
                    //context.Database.Connection.Open();

                var allImages = (
                    from image in context.ImageEntitys
                    select new ImageViewModel 
                    {
                        ImageId = image.ImageId,
                        Description = image.Description,
                        Photo = image.Photo
                    }).ToList();

                //context.Database.Connection.Close();
                return allImages;
            }
        }

        public ImageViewModel GetById(int Id)
        {
            using (ImageDataContext context = new ImageDataContext())
            {
               // context.Database.Connection.Open();

                var someImage = (
                    from image in context.ImageEntitys
                    where image.ImageId == Id
                    select new ImageViewModel
                    {
                        ImageId = image.ImageId,
                        Description = image.Description,
                        Photo = image.Photo
                    }
                ).FirstOrDefault();
                
               //context.Database.Connection.Close();
                return someImage;
            }
        }

        #endregion
    }
}
