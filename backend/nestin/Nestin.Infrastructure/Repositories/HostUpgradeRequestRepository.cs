using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class HostUpgradeRequestRepository : GenericRepository<HostUpgradeRequest, string>, IHostUpgradeRequestRepository
    {
        public HostUpgradeRequestRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
