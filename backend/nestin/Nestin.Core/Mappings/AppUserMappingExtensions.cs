using Nestin.Core.Dtos.Properties;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class AppUserMappingExtensions
    {
        public static PropertyOwnerDto ToDo(this AppUser user)
        {
            return new PropertyOwnerDto
            {
                Id = user.Id,
                UserName = user.UserName
            };
        }
    }
}
