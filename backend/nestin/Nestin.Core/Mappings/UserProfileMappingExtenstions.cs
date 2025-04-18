using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class UserProfileMappingExtenstions
    {
        public static UserProfileDto ToDto(this UserProfile userProfile)
        {
            return new UserProfileDto
            {
                UserId = userProfile.UserId,
                UserName = userProfile.AppUser.UserName,
                Email = userProfile.AppUser.Email,
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                PhoneNumber = userProfile.AppUser.PhoneNumber,
                Bio = userProfile.Bio,
                BirthDate = userProfile.BirthDate,
                Country = userProfile?.Country?.ToDto(),
                Photo = MapProfilePhoto(userProfile)
            };
        }

        public static void ToEntity(this UpdateUserProfileDto dto, UserProfile userProfile)
        {
            userProfile.FirstName = dto?.FirstName ?? userProfile.FirstName;
            userProfile.LastName = dto?.LastName ?? userProfile.LastName;
            userProfile.Bio = dto?.Bio ?? userProfile.Bio;
            userProfile.BirthDate = dto?.BirthDate ?? userProfile.BirthDate;
            userProfile.CountryId = dto?.CountryId ?? userProfile.CountryId;

            if (!string.IsNullOrEmpty(dto.PhoneNumber))
            {
                userProfile.AppUser.PhoneNumber = dto.PhoneNumber;
            }
        }

        private static UserProfilePhotoDto MapProfilePhoto(UserProfile userProfile)
        {
            return new UserProfilePhotoDto
            {
                Id = userProfile.PhotoId,
                PhotoUrl = userProfile?.Photo?.Path?.ToFullUrl()
            };
        }
    }
}
