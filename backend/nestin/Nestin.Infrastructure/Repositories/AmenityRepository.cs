using Microsoft.EntityFrameworkCore;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class AmenityRepository : GenericRepository<Amenity, int>, IAmenityRepository
    {
        public AmenityRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<bool> IsExistAsync(string propertyId, int amenityId)
        {
            var amenity = await _dbContext.PropertyAmenities.Where(x => x.PropertyId == propertyId && x.AmenityId == amenityId)
                .FirstOrDefaultAsync();

            return amenity is null ? false : true;
        }
    }
}
