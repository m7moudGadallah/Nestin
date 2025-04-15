namespace Nestin.Core.Dtos.Properties
{
    public class PropertyDetailsDto : PropertyListItemDto
    {
        public string? Description { get; set; }
        public string? SafteyInfo { get; set; }
        public string? HouseRules { get; set; }
        public string? CancellationPolicy { get; set; }
    }
}
