using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IUserProfileRepository : IBaseRepository
    {
        public Task<PaginatedResult<UserProfileDto>> GetFilteredProfilesAsync(UserProfileQueryParamsDto queryDto);
        public Task<UserProfile> GetByUserId(string userId);
        public Task<UserProfileDto> GetProfileDetailsByUserId(string userId);
        public Task CreateAsync(string userId);
        public void Update(UserProfile userProfile);
    }
}
