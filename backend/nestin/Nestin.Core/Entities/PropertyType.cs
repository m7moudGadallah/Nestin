namespace Nestin.Core.Entities
{
    public class PropertyType : BaseEntity<int>
    {
        public string Name { get; set; }
        public string? Icon { get; set; }
    }
}
