using System.ComponentModel.DataAnnotations;

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
