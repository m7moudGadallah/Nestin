using Nestin.Core.Dtos.Locations;
using Nestin.Core.Dtos.PropertyPhotos;
using Nestin.Core.Dtos.PropertyTypes;

namespace Nestin.Core.Dtos.Properties
{
    public class PropertyListItemDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public PropertyOwnerDto Owner { get; set; }
        public LocationDto Location { get; set; }
        public PropertyTypeDto PropertyType { get; set; }
        public List<PropertyPhotoDto>? Photos { get; set; }
        public double AverageRating { get; set; }
        public int ReviewCount { get; set; }
    }
}
