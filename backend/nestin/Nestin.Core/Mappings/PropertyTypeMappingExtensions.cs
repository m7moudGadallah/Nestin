using Nestin.Core.Dtos.PropertyTypes;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyTypeMappingExtensions
    {
        public static PropertyTypeDto ToDto(this PropertyType propertyType)
        {
            return new PropertyTypeDto
            {
                Id = propertyType.Id,
                Name = propertyType.Name,
                Icon = propertyType.Icon
            };
        }
    }
}
