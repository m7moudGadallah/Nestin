using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Interfaces
{
    public interface IUserProfileRepository : IBaseRepository
    {
        public Task<UserProfileViewDto> GetByUserIdAsync(string userId);

        public Task UpdateByUserId(string userId, UserprofileEditDto userprofileEditDto);
    }
}
