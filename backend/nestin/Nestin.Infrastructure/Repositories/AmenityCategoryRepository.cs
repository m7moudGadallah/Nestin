using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class AmenityCategoryRepository : GenericRepository<AmenityCategory, int>, IAmenityCategoryRepository
    {
        public AmenityCategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
