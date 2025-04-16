using Nestin.Core.Dtos.PropertySpaceItemTypes;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertySpaceItemTypeMappingExtenstions
    {
        public static PropertySpaceItemTypeDto ToDto(this PropertySpaceItemType propertySpaceItemType)
        {
            return new PropertySpaceItemTypeDto
            {
                Id = propertySpaceItemType.Id,
                Name = propertySpaceItemType.Name,
                PropertySpaceTypeId = propertySpaceItemType.PropertySpaceTypeId
            };
        }
    }
}
