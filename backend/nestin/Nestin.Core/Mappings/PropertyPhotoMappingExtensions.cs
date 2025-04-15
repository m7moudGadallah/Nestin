using Nestin.Core.Dtos.PropertyPhotos;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyPhotoMappingExtensions
    {
        public static PropertyPhotoDto ToDto(this PropertyPhoto propertyPhoto)
        {
            return new PropertyPhotoDto
            {
                Id = propertyPhoto.PhotoId,
                PhotoUrl = propertyPhoto.FileUpload.Path.ToFullUrl()
            };
        }
    }
}
