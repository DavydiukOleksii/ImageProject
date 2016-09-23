using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModels
{
    public class ImageViewModel
    {
        public int ImageId { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
    }
}
