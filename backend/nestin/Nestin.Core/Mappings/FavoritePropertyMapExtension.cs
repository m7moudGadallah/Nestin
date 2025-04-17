using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Nestin.Core.Mappings
{
    public static class FavoritePropertyMappingExtensions
    {
        // Mapping from DTO to Entity
        public static FavoriteProperty ToEntity(this FavoritePropertiesDto dto)
        {
            return new FavoriteProperty
            {
                UserId = dto.UserId,
                PropertyId = dto.PropertyId
            };
        }

        // Mapping from Entity to DTO
        public static FavoritePropertiesDto ToDto(this FavoriteProperty entity)
        {
            return new FavoritePropertiesDto
            {
                UserId = entity.UserId,
                PropertyId = entity.PropertyId
            };
        }

        // Mapping from list of entities to list of DTOs
        public static List<FavoritePropertiesDto> ToDtoList(this IEnumerable<FavoriteProperty> entities)
        {
            return entities.Select(e => e.ToDto()).ToList();
        }
    }
}
