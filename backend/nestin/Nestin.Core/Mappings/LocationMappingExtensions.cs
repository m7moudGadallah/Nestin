using Nestin.Core.Dtos.Locations;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class LocationMappingExtensions
    {
        public static LocationDto ToDto(this Location location)
        {
            return new LocationDto
            {
                Id = location.Id,
                Name = location.Name,
                CountryId = location.CountryId
            };
        }
    }
}
