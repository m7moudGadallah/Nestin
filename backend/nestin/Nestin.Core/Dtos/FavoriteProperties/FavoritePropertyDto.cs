using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.FavoriteProperties
{
    public class FavoritePropertyDto
    {
        [Required]
        public string PropertyId { get; set; }
        [Required]
        public string PropertyPhotoFullPath { get; set; }
    }
}
