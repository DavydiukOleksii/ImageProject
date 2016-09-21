using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
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
