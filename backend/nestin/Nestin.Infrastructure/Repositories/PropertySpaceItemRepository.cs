using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertySpaceItems;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertySpaceItemRepository : GenericRepository<PropertySpaceItem, int>, IPropertySpaceItemRepository
    {
        public PropertySpaceItemRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<PropertySpaceItemDto>> GetByPropertySpaceIdAsync(string propertySpaceId, GetAllQueryDto dto)
        {
            var query = _dbContext.PropertySpaceItems
                .Where(x => x.PropertySpaceId == propertySpaceId)
                .AsQueryable();

            var total = await query.CountAsync();

            var items = await query
                    .Skip(dto.CalcSkippedItems())
                    .Take(dto.PageSize)
                    .Select(x => x.ToDto())
                    .ToListAsync();

            return new PaginatedResult<PropertySpaceItemDto>
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
