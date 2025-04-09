using Nestin.Core.Dtos.Regions;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class RegionMappingExtensions
    {
        public static RegionDto ToDto(this Region region)
        {
            return new RegionDto
            {
                Id = region.Id,
                Name = region.Name
            };
        }
    }
}
