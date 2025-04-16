using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class GuestTypeRepository : GenericRepository<GuestType, int>, IGuestTypeReposiotry
    {
        public GuestTypeRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
