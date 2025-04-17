using Nestin.Core.Dtos.Properties;
using Nestin.Core.Dtos.PropertySpaceTypes;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyMappingExtensions
    {
        public static PropertyListItemDto ToPropertyListItemDto(this Property property)
        {
            var (averageRating, reviewCount) = CalculateRatingStats(property);

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
                AverageRating = averageRating,
                ReviewCount = reviewCount
            };
        }

        public static PropertyDetailsDto ToPropertyDetailsDto(this Property property)
        {
            var (averageRating, reviewCount) = CalculateRatingStats(property);

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
                AverageRating = averageRating,
                ReviewCount = reviewCount,
                MaxGuestCount = 0,
                SpaceSummaries = MapSpaceSummaries(property)
            };
        }

        private static (decimal averageRating, int reviewCount) CalculateRatingStats(Property property)
        {
            var reviews = property.Bookings?
                .Where(b => b.Review != null)
                .Select(b => b.Review)
                .ToList() ?? new List<Review>();

            var reviewCount = reviews.Count;
            var averageRating = reviewCount > 0
                ? reviews.Average(r => (r.Cleanliness + r.Accuracy + r.CheckIn +
                                      r.Communication + r.Location + r.Value) / 6)
                : 0;

            return (averageRating, reviewCount);
        }

        private static List<PropertySpaceSummaryDto> MapSpaceSummaries(Property property)
        {
            return property.PropertySpaces?
                .GroupBy(ps => new
                {
                    ps.PropertySpaceTypeId,
                    ps.PropertySpaceType.Name,
                    ps.IsShared
                })
                .Select(g => new PropertySpaceSummaryDto
                {
                    SpaceType = new PropertySpaceTypeDto
                    {
                        Id = g.Key.PropertySpaceTypeId,
                        Name = g.Key.Name
                    },
                    Count = g.Count(),
                    IsShared = g.Key.IsShared
                })
                .ToList() ?? new List<PropertySpaceSummaryDto>();
        }
    }
}
