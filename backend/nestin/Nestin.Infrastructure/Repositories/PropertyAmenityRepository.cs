using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertyAmenityRepository : BaseRepository, IPropertyAmenityRepository
    {
        public PropertyAmenityRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<PropertySpaceDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto)
        {
            var query = _dbContext.PropertyAmenities
                .Include(x => x.Amenity)
                .Where(x => x.PropertyId == propertyId)
                .AsQueryable();

            var total = await query.CountAsync();

            var items = await query
                    .Skip(dto.CalcSkippedItems())
                    .Take(dto.PageSize)
                    .Select(x => x.ToDto())
                    .ToListAsync();

            return new PaginatedResult<PropertySpaceDto>
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
