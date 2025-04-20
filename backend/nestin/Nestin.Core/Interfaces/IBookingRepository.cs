using Nestin.Core.Dtos.Bookings;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IBookingRepository : IGenericRepository<Booking, string>
    {
        public Task<PaginatedResult<BookingDto>> GetByUserIdAsync(string userId, GetAllBookingsQueryParamsDto queryDto);
        public Task<BookingDto> GetBookingDetailsByIdAsync(string bookingId);
        public Task CancelBookingAsync(string bookingId, string userId, bool isAdmin);
    }
}
