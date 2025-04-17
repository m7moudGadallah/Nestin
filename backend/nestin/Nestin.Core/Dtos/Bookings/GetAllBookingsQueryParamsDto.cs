namespace Nestin.Core.Dtos.Bookings
{
    public class GetAllBookingsQueryParamsDto : GetAllQueryDto
    {
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string? Status { get; set; }
    }
}
