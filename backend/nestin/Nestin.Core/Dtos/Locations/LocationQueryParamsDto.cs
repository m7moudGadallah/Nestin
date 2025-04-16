namespace Nestin.Core.Dtos.Locations
{
    public class LocationQueryParamsDto : GetAllQueryDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
    }
}
