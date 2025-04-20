using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertyGuestRepository : BaseRepository, IPropertyGuestRepository
    {
        public PropertyGuestRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<PropertyGuestsDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto)
        {
            var query = _dbContext.PropertyGuests
                .Include(x => x.GuestType)
                .Where(x => x.PropertyId == propertyId)
                .AsQueryable();

            var total = await query.CountAsync();

            var items = await query
                    .Skip(dto.CalcSkippedItems())
                    .Take(dto.PageSize)
                    .Select(x => x.ToDo())
                    .ToListAsync();

            return new PaginatedResult<PropertyGuestsDto>
            {
                Items = items,
                MetaData = new PaginationMetaData
                {
                    Total = total,
                    Page = dto.Page,
                    PageSize = dto.PageSize
                }
            };
        }
    }
}
