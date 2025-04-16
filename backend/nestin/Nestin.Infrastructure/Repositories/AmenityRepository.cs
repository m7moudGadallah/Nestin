using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class AmenityRepository : GenericRepository<Amenity, int>, IAmenityRepository
    {
        public AmenityRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
