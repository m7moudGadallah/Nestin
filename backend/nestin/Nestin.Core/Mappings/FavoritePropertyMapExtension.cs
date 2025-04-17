using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Nestin.Core.Mappings
{
    public static class FavoritePropertyMappingExtensions
    {
        
        public static FavoriteProperty ToEntity(this FavoritePropertiesDto dto)
        {
            return new FavoriteProperty
            {
                UserId = dto.UserId,
                PropertyId = dto.PropertyId
            };
        }

       
        public static FavoritePropertiesDto ToDto(this FavoriteProperty entity)
        {
            return new FavoritePropertiesDto
            {
                UserId = entity.UserId,
                PropertyId = entity.PropertyId
            };
        }

        
        public static List<FavoritePropertiesDto> ToDtoList(this IEnumerable<FavoriteProperty> entities)
        {
            return entities.Select(e => e.ToDto()).ToList();
        }
    }
}
