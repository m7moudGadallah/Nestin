using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyAmenityMappingExtensions
    {
        public static PropertyAmenityDto ToDo(this PropertyAmenity propertyAmenity)
        {
            return new PropertyAmenityDto
            {
                PropertyId = propertyAmenity.PropertyId,
                Amenity = propertyAmenity.Amenity.ToDto()
            };
        }
    }
}
