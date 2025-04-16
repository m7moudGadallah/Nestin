using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyAmenityMappingExtensions
    {
        public static PropertySpaceDto ToDto(this PropertyAmenity propertyAmenity)
        {
            return new PropertySpaceDto
            {
                PropertyId = propertyAmenity.PropertyId,
                Amenity = propertyAmenity.Amenity.ToDto()
            };
        }
    }
}
