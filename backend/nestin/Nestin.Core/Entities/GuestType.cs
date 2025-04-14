namespace Nestin.Core.Entities
{
    public class GuestType : BaseEntity<int>
    {
        public string Name { get; set; }
        public virtual ICollection<PropertyGuest> PropertyGuests { get; set; } = new HashSet<PropertyGuest>();
    }
}
