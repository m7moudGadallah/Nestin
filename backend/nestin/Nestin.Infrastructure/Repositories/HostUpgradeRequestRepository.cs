using Microsoft.EntityFrameworkCore;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class HostUpgradeRequestRepository : GenericRepository<HostUpgradeRequest, string>, IHostUpgradeRequestRepository
    {
        public HostUpgradeRequestRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<HostUpgradeRequest?> GetPendingRequestByUserIdAsync(string userId)
        {
            return await _dbContext.HostUpgradeRequests
                .Include(x => x.FrontPhoto)
                .Include(x => x.BackPhoto)
                .Where(r => r.UserId == userId && r.Status == HostUgradeRequestStatus.Pending)
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync();
        }
    }
}
