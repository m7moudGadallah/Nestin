using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.Bookings;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class BookingRepository : GenericRepository<Booking, string>, IBookingRepository
    {
        public BookingRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<BookingDto>> GetByUserIdAsync(string userId, GetAllBookingsQueryParamsDto queryDto)
        {
            var query = _dbContext.Bookings
               .Include(x => x.BookingGuests)
               .Include(x => x.Property)
               .ThenInclude(x => x.Bookings)
                .ThenInclude(x => x.Review)
                .Include(x => x.Property)
                .ThenInclude(x => x.PropertyPhotos)
                .ThenInclude(x => x.FileUpload)
                .Include(x => x.Property)
                .ThenInclude(x => x.Owner)
                .Include(x => x.Property)
                .ThenInclude(x => x.Location)
                .Include(x => x.Property)
                .ThenInclude(x => x.PropertyType)
               .Where(x => x.UserId == userId)
               .AsQueryable();


            if (queryDto.Status is not null)
                query = query.Where(x => x.Status == queryDto.GetStatusAsEnum());

            if (queryDto.CheckIn is not null)
                query = query.Where(x => x.CheckIn == queryDto.CheckIn);

            if (queryDto.CheckOut is not null)
                query = query.Where(x => x.CheckOut == queryDto.CheckOut);

            var total = await query.CountAsync();

            var items = await query
                .Skip(queryDto.CalcSkippedItems())
                .Take(queryDto.PageSize)
                .Select(x => x.ToDto())
                .ToListAsync();

            return new PaginatedResult<BookingDto>
            {
                Items = items,
                MetaData = new PaginationMetaData
                {
                    Page = queryDto.Page,
                    PageSize = queryDto.PageSize,
                    Total = total
                }
            };
        }

        public async Task<BookingDto> GetBookingDetailsByIdAsync(string bookingId)
        {
            var query = _dbContext.Bookings
               .Include(x => x.BookingGuests)
               .Include(x => x.Property)
               .ThenInclude(x => x.Bookings)
                .ThenInclude(x => x.Review)
                .Include(x => x.Property)
                .ThenInclude(x => x.PropertyPhotos)
                .ThenInclude(x => x.FileUpload)
                .Include(x => x.Property)
                .ThenInclude(x => x.Owner)
                .Include(x => x.Property)
                .ThenInclude(x => x.Location)
                .Include(x => x.Property)
                .ThenInclude(x => x.PropertyType)
               .Where(x => x.Id == bookingId)
               .AsQueryable();

            var booking = await query
                                .Select(x => x.ToDto())
                                .FirstOrDefaultAsync();
            return booking;
        }
    }
}
