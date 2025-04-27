using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.PropertyAvailabilities
{
    public class PropertyAvailabilityUpdateDto
    {
        [Required]
        public string PropertyId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
