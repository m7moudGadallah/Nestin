using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class FavoritePropertyMappingExtensions
    {

        public static FavoriteProperty ToEntity(this CreateFavoritePropertyDto dto)
        {
            return new FavoriteProperty
            {
                PropertyId = dto.PropertyId
            };
        }


        public static FavoritePropertyDto ToDto(this FavoriteProperty entity)
        {
            // TODO: Map property photo
            //entity.Property.PropertyPhotos.OrderBy(x => x.TouchedAt).FirstOrDefault().FileUpload.Path.ToFullUrl()
            return new FavoritePropertyDto
            {
                PropertyId = entity.PropertyId
            };
        }
    }
}
