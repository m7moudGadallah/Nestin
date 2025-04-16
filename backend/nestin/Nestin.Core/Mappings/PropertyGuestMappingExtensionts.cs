using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyGuestMappingExtensionts
    {
        public static PropertyGuestsDto ToDo(this PropertyGuest propertyGuest)
        {
            return new PropertyGuestsDto
            {
                PropertyId = propertyGuest.PropertyId,
                GuestType = propertyGuest.GuestType.ToDto(),
                GuestCount = propertyGuest.GuestCount
            };
        }
    }
}
