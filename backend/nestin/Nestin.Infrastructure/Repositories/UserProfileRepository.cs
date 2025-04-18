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

        public async Task<UserProfileDto> GetByUserIdAsync(string userId)
        {
            var query = _dbContext.UserProfiles.Include(u => u.AppUser)
                .Include(u => u.Country)
                .Include(u => u.AppUser)
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

        public async Task UpdateByUserId(string userId, UserprofileEditDto dto)
        {
            var userProfile = await _dbContext.UserProfiles
                .Include(u => u.AppUser)
                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (userProfile == null)
                throw new ArgumentException("User not found");

            // Update fields from dto
            userProfile.FirstName = dto.FirstName;
            userProfile.LastName = dto.LastName;
            userProfile.Bio = dto.Bio;
            userProfile.BirthDate = dto.BirthDate;
            userProfile.CountryId = dto.CountryId;
            userProfile.PhotoId = dto.PhotoId;

            // Update AppUser PhoneNumber
            if (userProfile.AppUser != null)
            {
                userProfile.AppUser.PhoneNumber = dto.PhoneNumber;
            }


        }
    }
}
