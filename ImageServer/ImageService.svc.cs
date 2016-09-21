using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataViewModels;
using DataRepository;

namespace ImageServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ImageService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ImageService.svc or ImageService.svc.cs at the Solution Explorer and start debugging.
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
