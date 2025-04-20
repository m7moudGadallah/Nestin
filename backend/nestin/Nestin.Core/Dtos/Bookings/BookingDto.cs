using Nestin.Core.Dtos.BookingGuests;
using Nestin.Core.Dtos.Properties;

namespace Nestin.Core.Dtos.Bookings
{
    public class BookingDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalFees { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<BookingGuestDto> BookingGuests { get; set; }
        public PropertyListItemDto Property { get; set; }
    }
}
