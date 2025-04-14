namespace Nestin.Core.Entities
{
    public class Location : BaseEntity<int>
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
