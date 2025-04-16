using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertyAvailabilityRepository : GenericRepository<PropertyAvailability, int>, IPropertyAvailabilityRepository
    {
        public PropertyAvailabilityRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<PropertyAvailabilityDto>> GetByPropertyId(string propertyId, PropertyAvailabilityQueryParamsDto queryDto)
        {
            var query = _dbContext.PropertyAvailabilities
               .Where(x => x.PropertyId == propertyId)
               .AsQueryable();
            // TODO: Handle booking checking
            if (queryDto.StartDate.HasValue)
            {
                var checkInDate = queryDto.StartDate.Value.ToDateTime(TimeOnly.MinValue);

                if (queryDto.EndDate.HasValue)
                {
                    var checkOutDate = queryDto.EndDate.Value.ToDateTime(TimeOnly.MinValue);

                    query = query.Where(x =>
                            x.StartDate <= checkOutDate &&  // Availability starts before or on checkout
                            x.EndDate >= checkInDate
                    );
                }
                else
                {
                    // Only check-in date provided
                    query = query.Where(x =>
                            x.StartDate <= checkInDate &&
                            x.EndDate >= checkInDate
                    );
                }
            }

            var total = await query.CountAsync();

            var items = await query
                    .Skip(queryDto.CalcSkippedItems())
                    .Take(queryDto.PageSize)
                    .Select(x => x.ToDto())
                    .ToListAsync();

            return new PaginatedResult<PropertyAvailabilityDto>
            {
                Items = items,
                MetaData = new PaginationMetaData
                {
                    Total = total,
                    Page = queryDto.Page,
                    PageSize = queryDto.PageSize
                }
            };
        }
    }
}
