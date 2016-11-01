using System.Collections.Generic;
using System.Linq;
using DataViewModels;
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

        #region PublicMethods
        public List<ImageViewModel> GetAll()
        {
            using(ImageDataContext context = new ImageDataContext())
            {
                var allImages = (
                    from image in context.ImageEntitys
                    select new ImageViewModel 
                    {
                        ImageId = image.ImageId,
                        Description = image.Description,
                        Photo = image.Photo
                    }).ToList();
                return allImages;
            }
        }

        public ImageViewModel GetById(int Id)
        {
            using (ImageDataContext context = new ImageDataContext())
            {
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
                return someImage;
            }
        }
        #endregion
    }
}
