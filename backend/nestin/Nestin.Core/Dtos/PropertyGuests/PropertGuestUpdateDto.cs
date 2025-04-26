using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.PropertyGuests
{
    public class PropertGuestUpdateDto
    {
        [Required]
        public string PropertyId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "GuestTypeId must be greater than 1")]
        public int GuestTypeId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "GuestCount must be greater than 1")]
        public int GuestCount { get; set; }
    }
}

