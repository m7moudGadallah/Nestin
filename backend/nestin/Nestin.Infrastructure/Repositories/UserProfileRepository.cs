using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    internal class UserProfileRepository : BaseRepository, IUserProfileRepository
    {
        public UserProfileRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<UserProfile> GetByUserId(string userId)
        {
            var query =
                _dbContext.UserProfiles.Include(u => u.AppUser)
                  .Include(u => u.Country)
                  .Include(u => u.AppUser)
                  .Include(u => u.Photo)
                  .Where(x => x.UserId == userId);

            var user = await query.FirstOrDefaultAsync();

            if (user is null)
            {
                await CreateAsync(userId);
            }

            return await query.FirstAsync();
        }

        public async Task<UserProfileDto> GetProfileDetailsByUserId(string userId)
        {
            var query = _dbContext.UserProfiles.Include(u => u.AppUser)
                .Include(u => u.Country)
                .Include(u => u.AppUser)
                .ThenInclude(u => u.Roles)
                .Include(u => u.Photo)
                .Where(u => u.UserId == userId)
                .Select(u => u.ToDto());

            var user = await query.FirstOrDefaultAsync();

            if (user is null)
            {
                await CreateAsync(userId);
            }

            return await query.FirstOrDefaultAsync(); ;
        }

        public async Task CreateAsync(string userId)
        {
            var newUserProfile = _dbContext.Add(new UserProfile
            {
                UserId = userId,
            });

            await SaveChangesAsync();
        }

        public void Update(UserProfile userProfile)
        {
            _dbContext.Update(userProfile);
        }
    }
}
