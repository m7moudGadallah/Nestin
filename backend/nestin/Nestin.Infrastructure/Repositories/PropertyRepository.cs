using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.Properties;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertyRepository : GenericRepository<Property, string>, IPropertyRepository
    {
        public PropertyRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<PaginatedResult<PropertyListItemDto>> GetFilteredPropertiesAsync(FilterPropertyQueryParamsDto queryDto)
        {
            var query = _dbContext.Properties
                    .Include(x => x.Owner)
                    .Include(x => x.Location)
                    .Include(x => x.PropertyType)
                    .Include(x => x.PropertyPhotos)
                    .ThenInclude(x => x.FileUpload)
                    .Include(x => x.Bookings)
                    .ThenInclude(x => x.Review)
                    .AsQueryable();

            // Fitlers
            if (queryDto.LocationId.HasValue)
            {
                query = query.Where(x => x.LocationId == queryDto.LocationId.Value);
            }
            else if (!string.IsNullOrEmpty(queryDto.LocationName))
            {
                query = query.Where(x => EF.Functions.Like(x.Location.Name, $"%{queryDto.LocationName}%"));
            }

            if (queryDto.PropertyTypeId.HasValue)
                query = query.Where(x => x.PropertyTypeId == queryDto.PropertyTypeId.Value);

            if (queryDto.GuestCount.HasValue)
                query = query.Where(x => x.PropertyGuests.Sum(pg => pg.GuestCount) >= queryDto.GuestCount.Value);

            if (queryDto.PriceMin.HasValue)
                query = query.Where(x => x.PricePerNight >= queryDto.PriceMin.Value);

            if (queryDto.PriceMax.HasValue)
                query = query.Where(x => x.PricePerNight <= queryDto.PriceMax.Value);


            if (queryDto.CheckIn.HasValue)
            {
                var checkInDate = queryDto.CheckIn.Value.ToDateTime(TimeOnly.MinValue);

                if (queryDto.CheckOut.HasValue)
                {
                    var checkOutDate = queryDto.CheckOut.Value.ToDateTime(TimeOnly.MinValue);

                    query = query.Where(x =>
                        x.PropertyAvailabilities.Any(pa =>
                            pa.StartDate <= checkOutDate &&
                            pa.EndDate >= checkInDate
                        ) &&
                        !x.Bookings.Any(b =>
                            b.Status != BookingStatus.Canceled &&
                            b.CheckIn < checkOutDate &&
                            b.CheckOut > checkInDate
                        )
                    );
                }
                else
                {
                    query = query.Where(x =>
                        x.PropertyAvailabilities.Any(pa =>
                            pa.StartDate <= checkInDate &&
                            pa.EndDate >= checkInDate
                        ) &&
                        !x.Bookings.Any(b =>
                            b.Status != BookingStatus.Canceled &&
                            b.CheckIn <= checkInDate &&
                            b.CheckOut > checkInDate
                        )
                    );
                }
            }

            if (queryDto.CountryId.HasValue)
                query = query.Where(x => x.Location.CountryId == queryDto.CountryId.Value);

            if (queryDto.RegionId.HasValue)
                query = query.Where(x => x.Location.Country.RegionId == queryDto.RegionId.Value);

            query = queryDto.Sort switch
            {
                "price_asc" => query.OrderByDescending(x => x.PricePerNight),
                "price_dec" => query.OrderBy(x => x.PricePerNight),
                "rating" => query.OrderByDescending(x =>
                    x.Bookings
                     .Where(b => b.Review != null)
                     .Average(b =>
                         (b.Review.Cleanliness + b.Review.Accuracy + b.Review.CheckIn +
                          b.Review.Communication + b.Review.Location + b.Review.Value) / 6m)
                ),
                _ => query.OrderByDescending(x => x.PricePerNight)
            };

            // Pagination
            var total = await query.CountAsync();
            var items = await query.Skip(queryDto.CalcSkippedItems()).Take(queryDto.PageSize).Select(p => p.ToPropertyListItemDto()).ToListAsync();

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

        public async Task<PropertyDetailsDto?> GetPropertyDetails(string id)
        {
            var property = await _dbContext.Properties
                .Include(x => x.Owner)
                .Include(x => x.Location)
                .Include(x => x.PropertyType)
                .Include(x => x.PropertyPhotos)
                .ThenInclude(x => x.FileUpload)
                .Where(x => x.Id == id)
                .Select(p => p.ToPropertyDetailsDto()).FirstOrDefaultAsync();

            return property;
        }
    }
}
