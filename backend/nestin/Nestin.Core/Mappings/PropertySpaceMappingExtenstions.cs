using Nestin.Core.Dtos.PropertySpaces;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertySpaceMappingExtenstions
    {
        public static PropertySpaceDto ToDto(this PropertySpace propertySpace)
        {
            return new PropertySpaceDto
            {
                Id = propertySpace.Id,
                Name = propertySpace.Name,
                IsShared = propertySpace.IsShared,
                PropertySpaceTypeId = propertySpace.PropertySpaceTypeId,
                PropertyId = propertySpace.PropertyId
            };
        }
    }
}
