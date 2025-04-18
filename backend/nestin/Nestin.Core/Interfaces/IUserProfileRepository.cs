using Nestin.Core.Dtos.UserProfilesDto;

namespace Nestin.Core.Interfaces
{
    public interface IUserProfileRepository : IBaseRepository
    {
        public Task<UserProfileDto> GetByUserIdAsync(string userId);
        public Task CreateAsync(string userId);
        public Task UpdateByUserId(string userId, UpdateUserProfileDto userprofileEditDto);
    }
}
