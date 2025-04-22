using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.Bookings
{
    public class BookingCheckoutDto
    {
        [Required]
        public string BookingId { get; set; }
    }
}
