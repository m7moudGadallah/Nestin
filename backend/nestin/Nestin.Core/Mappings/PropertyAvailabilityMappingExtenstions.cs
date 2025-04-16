using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyAvailabilityMappingExtenstions
    {
        public static PropertyAvailabilityDto ToDto(this PropertyAvailability propertyAvailability)
        {
            return new PropertyAvailabilityDto
            {
                Id = propertyAvailability.Id,
                StartDate = propertyAvailability.StartDate,
                EndDate = propertyAvailability.EndDate,
                PropertyId = propertyAvailability.PropertyId
            };
        }
    }
}
