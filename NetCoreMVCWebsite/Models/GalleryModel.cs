using System.ComponentModel.DataAnnotations;

namespace NetCoreMVCWebsite.Models
{
    public class GalleryModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Path { get; set; }
    }
}