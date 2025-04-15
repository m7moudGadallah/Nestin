using Nestin.Core.Dtos.GuestTypes;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class GuestTypeMappingExtensions
    {
        public static GuestTypesDto ToDo(this GuestType guestType)
        {
            return new GuestTypesDto
            {
                Id = guestType.Id,
                Name = guestType.Name
            };
        }
    }
}
