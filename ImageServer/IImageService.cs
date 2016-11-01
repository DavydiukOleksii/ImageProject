using System.Collections.Generic;
using System.ServiceModel;
using DataViewModels;

namespace ImageServer
{
    [ServiceContract]
    public interface IImageService
    {
        [OperationContract]
        IEnumerable<ImageViewModel> GetAll();

        [OperationContract]
        ImageViewModel GetById(int Id);
    }
}
