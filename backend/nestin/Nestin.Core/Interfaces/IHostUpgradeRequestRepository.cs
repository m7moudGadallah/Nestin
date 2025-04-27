using Nestin.Core.Dtos.HostUpgradeRequests;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IHostUpgradeRequestRepository : IGenericRepository<HostUpgradeRequest, string>
    {
        public Task<PaginatedResult<HostUpgradeRequestDto>> GetAllAsync(HostUpgradeRequestFilterQueryParamsDto queryDto);
        public Task<HostUpgradeRequest?> GetPendingRequestByUserIdAsync(string userId);
        public Task<HostUpgradeRequest?> GetLastRequestByUserIdASync(string userId);
    }
}
