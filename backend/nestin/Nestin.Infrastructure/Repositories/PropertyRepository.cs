using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.Properties;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    public class PropertyRepository : GenericRepository<Property, string>, IPropertyRepository
    {
        public PropertyRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<PropertyListItemDto>> GetFilteredPropertiesAsync(FilterPropertyQueryParamsDto queryDto)
        {
            var query = _dbContext.Properties
                    .Include(x => x.Location)
                    .Include(x => x.PropertyType)
                    .Include(x => x.PropertyPhotos)
                    .ThenInclude(x => x.FileUpload)
                    .AsQueryable();

            // Fitlers
            if (queryDto.LocationId.HasValue)
                query = query.Where(x => x.LocationId == queryDto.LocationId.Value);

            if (queryDto.GuestCount.HasValue)
                query = query.Where(x => x.PropertyGuests.Sum(pg => pg.GuestCount) >= queryDto.GuestCount.Value);

            if (queryDto.PriceMin.HasValue)
                query = query.Where(x => x.PricePerNight >= queryDto.PriceMin.Value);

            if (queryDto.PriceMax.HasValue)
                query = query.Where(x => x.PricePerNight <= queryDto.PriceMax.Value);


            //TODO: Handle CheckIn Checkout filters

            if (queryDto.CountryId.HasValue)
                query = query.Where(x => x.Location.CountryId == queryDto.CountryId.Value);

            if (queryDto.RegionId.HasValue)
                query = query.Where(x => x.Location.Country.RegionId == queryDto.RegionId.Value);

            // TODO: Handle ordering based on rating
            query = queryDto.Sort switch
            {
                "price_asc" => query.OrderByDescending(x => x.PricePerNight),
                "price_dec" => query.OrderBy(x => x.PricePerNight),
                _ => query.OrderBy(x => x.Id)
            };

            // Pagination
            var total = await query.CountAsync();
            var items = await query.Skip(queryDto.CalcSkippedItems()).Take(queryDto.PageSize).Select(p => new PropertyListItemDto
            {
                Id = p.Id,
                Title = p.Title,
                OwnerId = p.OwnerId,
                PricePerNight = p.PricePerNight,
                Latitude = p.Latitude,
                Longitude = p.Longitude,
                Location = p.Location.ToDto(),
                PropertyType = p.PropertyType.ToDto(),
                MainPhoto = p.PropertyPhotos.OrderBy(x => x.TouchedAt).First().ToDto()
            }).ToListAsync();

            return new()
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
