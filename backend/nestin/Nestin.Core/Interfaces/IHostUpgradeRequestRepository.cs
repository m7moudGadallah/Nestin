using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IHostUpgradeRequestRepository : IGenericRepository<HostUpgradeRequest, string>
    {
        public Task<HostUpgradeRequest?> GetPendingRequestByUserIdAsync(string userId);
        public Task<HostUpgradeRequest?> GetLastRequestByUserIdASync(string userId);
    }
}
