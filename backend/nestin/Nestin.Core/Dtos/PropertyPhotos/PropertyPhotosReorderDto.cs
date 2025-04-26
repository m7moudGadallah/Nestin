using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.PropertyPhotos
{
    public class PropertyPhotosReorderDto
    {
        [Required]
        public List<string> PhotoIds { get; set; }
    }
}
