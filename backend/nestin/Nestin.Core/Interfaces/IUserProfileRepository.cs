using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IUserProfileRepository : IBaseRepository
    {
        public Task<UserProfile> GetByUserId(string userId);
        public Task<UserProfileDto> GetProfileDetailsByUserId(string userId);
        public Task CreateAsync(string userId);
        public void Update(UserProfile userProfile);
    }
}
