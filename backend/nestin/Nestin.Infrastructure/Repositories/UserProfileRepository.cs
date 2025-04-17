using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Infrastructure.Repositories
{
    internal class UserProfileRepository :BaseRepository, IUserProfileRepository
    {
        public UserProfileRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<UserProfileViewDto> GetByUserIdAsync(string userId)
        {
            var user = await _dbContext.UserProfiles.Include(u=>u.AppUser)
                .Where(u => u.UserId == userId)
                .Select(u => new UserProfileViewDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    PhoneNumber = u.AppUser.PhoneNumber,
                    Bio = u.Bio,
                    BirthDate = u.BirthDate,
                    UserName = u.AppUser.UserName,
                    CountryId =u.CountryId,
                    PhotoId = u.PhotoId
                })
                .FirstOrDefaultAsync();

            if (user == null)
                throw new ArgumentException("Invalid user ID");

            return user;
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
