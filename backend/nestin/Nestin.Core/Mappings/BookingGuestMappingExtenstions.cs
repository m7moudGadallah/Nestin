using Nestin.Core.Dtos.BookingGuests;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class BookingGuestMappingExtenstions
    {
        public static BookingGuestDto ToDto(this BookingGuest bookingGuest)
        {
            return new BookingGuestDto
            {
                BookingId = bookingGuest.BookingId,
                GuestTypeId = bookingGuest.GuestTypeId,
                GuestCount = bookingGuest.GuestCount
            };
        }
    }
}
