using Nestin.Core.Dtos.Reviews;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class ReviewMappingExtenstions
    {
        public static ReviewDto ToDto(this Review entity)
        {
            return new ReviewDto
            {
                BookingId = entity.BookingId,
                Comment = entity.Comment,
                Cleanliness = entity.Cleanliness,
                Accuracy = entity.Accuracy,
                CheckIn = entity.CheckIn,
                Communication = entity.Communication,
                Location = entity.Location,
                Value = entity.Value,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Reviewr = entity.Booking?.User == null ? null : new Reviewr
                {
                    Id = entity.Booking.User.Id,
                    FirstName = entity.Booking.User?.UserProfile?.FirstName,
                    LastName = entity.Booking.User?.UserProfile?.LastName,
                    PhotoUrl = entity.Booking.User?.UserProfile?.Photo?.Path?.ToFullUrl()
                }
            };
        }
    }
}
