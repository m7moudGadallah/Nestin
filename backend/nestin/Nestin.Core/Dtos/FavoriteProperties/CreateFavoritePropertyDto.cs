using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.FavoriteProperties
{
    public class CreateFavoritePropertyDto
    {
        [Required]
        public string PropertyId { get; set; }
    }
}
