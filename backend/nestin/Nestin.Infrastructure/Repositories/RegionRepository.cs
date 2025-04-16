using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class RegionRepository : GenericRepository<Region, int>, IRegionRepository
    {
        public RegionRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
