using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyGuestMappingExtensionts
    {
        public static PropertyGuestDto ToDto(this PropertyGuest propertyGuest)
        {
            return new PropertyGuestDto
            {
                PropertyId = propertyGuest.PropertyId,
                GuestType = propertyGuest.GuestType.ToDto(),
                GuestCount = propertyGuest.GuestCount
            };
        }
    }
}
