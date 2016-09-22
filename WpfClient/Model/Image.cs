using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Model
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
    }
}
