using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageData.Entitys
{
    public class ImageEntity
    {
        [Key]
        public int ImageId { get; set; }
        
        [MaxLength(500)]
        public string Description { get; set; }

        public byte[] Photo { get; set; }
    }
}
