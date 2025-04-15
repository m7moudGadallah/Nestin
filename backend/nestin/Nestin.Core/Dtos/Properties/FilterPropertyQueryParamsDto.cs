namespace Nestin.Core.Dtos.Properties
{
    public class FilterPropertyQueryParamsDto : GetAllQueryDto
    {
        public int? LocationId { get; set; }
        public int? PropertyTypeId { get; set; }
        public int? GuestCount { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
        public DateOnly? CheckIn { get; set; }
        public DateOnly? CheckOut { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public string? Sort { get; set; }
    }
}
