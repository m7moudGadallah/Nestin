using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.Reviews;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class ReviewRepository : GenericRepository<Review, string>, IReviewRepository
    {
        public ReviewRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PaginatedResult<ReviewDto>> GetPropertyReviews(string propertyId, GetAllQueryDto dto)
        {
            var query = _dbContext.Reviews
                .Include(x => x.Booking)
                .ThenInclude(x => x.User)
                .ThenInclude(x => x.UserProfile)
                .ThenInclude(x => x.Photo)
                .Include(x => x.Booking)
                .ThenInclude(x => x.Property)
                .Where(x => x.Booking.PropertyId == propertyId)
                .AsQueryable();

            var total = await query.CountAsync();

            var items = await query
                .Skip(dto.CalcSkippedItems())
                .Take(dto.PageSize)
                .Select(x => x.ToDto())
                .ToListAsync();

            return new PaginatedResult<ReviewDto>
            {
                Items = items,
                MetaData = new PaginationMetaData
                {
                    Page = dto.Page,
                    PageSize = dto.PageSize,
                    Total = total,
                }
            };
        }

        public async Task<ReviewDto?> GetReviewDetails(string reviewId)
        {
            var query = _dbContext.Reviews
            .Include(x => x.Booking)
            .ThenInclude(x => x.User)
            .ThenInclude(x => x.UserProfile)
            .ThenInclude(x => x.Photo)
            .Include(x => x.Booking)
            .ThenInclude(x => x.Property)
            .Where(x => x.Id == reviewId)
            .AsQueryable();

            return await query.Select(x => x.ToDto()).FirstOrDefaultAsync();
        }
    }
}
