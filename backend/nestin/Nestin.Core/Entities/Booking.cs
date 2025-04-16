namespace Nestin.Core.Entities
{
    [Flags]
    public enum BookingStatus
    {
        Pending = 1,
        Confirmed = 2,
        Canceled = 3
    }

    public class Booking : BaseEntity<string>
    {
        public string PropertyId { get; set; }
        public string UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalFees { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Property Property { get; set; }
        public virtual AppUser User { get; set; }
        public virtual ICollection<BookingGuest> BookingGuests { get; set; } = new HashSet<BookingGuest>();
    }
}
