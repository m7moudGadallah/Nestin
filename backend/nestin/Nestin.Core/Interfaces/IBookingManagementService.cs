using Nestin.Core.Dtos.Bookings;
using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IBookingManagementService
    {
        public Task<Booking> CreateBookingAsync(string userId, CreateBookingDto dto);
    }
}
