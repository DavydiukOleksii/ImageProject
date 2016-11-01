using System.Collections.Generic;
using DataRepository;
using DataViewModels;

namespace ImageServer
{
    public class ImageService : IImageService
    {

        public IEnumerable<ImageViewModel> GetAll()
        {
            return ImageRepository.Instance.GetAll();
        }

        public ImageViewModel GetById(int Id)
        {
            return ImageRepository.Instance.GetById(Id);
        }

    }
}
