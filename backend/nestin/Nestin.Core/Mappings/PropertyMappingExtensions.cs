using Nestin.Core.Dtos.Properties;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyMappingExtensions
    {
        public static PropertyListItemDto ToPropertyListItemDto(this Property property)
        {
            return new PropertyListItemDto
            {
                Id = property.Id,
                Title = property.Title,
                PricePerNight = property.PricePerNight,
                Latitude = property.Latitude,
                Longitude = property.Longitude,
                Owner = property.Owner.ToDto(),
                Location = property.Location.ToDto(),
                PropertyType = property.PropertyType.ToDto(),
                Photos = property.PropertyPhotos.OrderBy(x => x.TouchedAt).Select(photo => photo.ToDto()).ToList(),
                AverageRating = 0, // TODO: replace it with the actual rating
                ReviewCount = 0 // TODO: replace it with the actual reviw count 
            };
        }

        public static PropertyDetailsDto ToPropertyDetailsDto(this Property property)
        {
            return new PropertyDetailsDto
            {
                Id = property.Id,
                Title = property.Title,
                Description = property.Description,
                PricePerNight = property.PricePerNight,
                Latitude = property.Latitude,
                Longitude = property.Longitude,
                SafteyInfo = property.SafteyInfo,
                HouseRules = property.HouseRules,
                CancellationPolicy = property.CancellationPolicy,
                Owner = property.Owner.ToDto(),
                Location = property.Location.ToDto(),
                PropertyType = property.PropertyType.ToDto(),
                Photos = property.PropertyPhotos.OrderBy(x => x.TouchedAt).Select(photo => photo.ToDto()).ToList(),
                AverageRating = 0, // TODO: replace it with the actual rating
                ReviewCount = 0 // TODO: replace it with the actual reviw count 
            };
        }
    }
}
