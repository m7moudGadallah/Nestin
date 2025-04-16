using Nestin.Core.Dtos.PropertySpaceTypes;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertySpaceTypeMappingExtensionts
    {
        public static PropertySpaceTypeDto ToDto(this PropertySpaceType propertySpaceType)
        {
            return new PropertySpaceTypeDto
            {
                Id = propertySpaceType.Id,
                Name = propertySpaceType.Name
            };
        }
    }
}
