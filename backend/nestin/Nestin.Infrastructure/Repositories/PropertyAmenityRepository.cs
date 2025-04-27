using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Entities;
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

        public void Create(PropertyAmenity entity)
        {
            _dbContext.Add(entity);
        }

        public void Delete(PropertyAmenity entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task DeleteAsync(string propertyId, int amenityId)
        {
            var propertyAmenity = await GetPropertyAmenityAsync(propertyId, amenityId);

            if (propertyAmenity is null) return;
            _dbContext.Remove(propertyAmenity);
        }

        public async Task<PropertyAmenity?> GetPropertyAmenityAsync(string propertyId, int amenityId)
        {
            return await _dbContext.PropertyAmenities
                .Include(x => x.Amenity)
                .FirstOrDefaultAsync(x => x.PropertyId == propertyId && x.AmenityId == amenityId);
        }

        public async Task<PaginatedResult<PropertyAmenityDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto)
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

            return new PaginatedResult<PropertyAmenityDto>
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
