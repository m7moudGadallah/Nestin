using Nestin.Core.Dtos.Amenities;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class AmenityMappingExtenstions
    {
        public static AmenityDto ToDto(this Amenity amenity)
        {
            return new AmenityDto
            {
                Id = amenity.Id,
                Name = amenity.Name,
                Icon = amenity?.Icon,
                CategoryId = amenity.CategoryId
            };
        }
    }
}
