namespace Nestin.Core.Entities
{
    public class Country : BaseEntity<int>
    {
        public string Name { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
    }
}
