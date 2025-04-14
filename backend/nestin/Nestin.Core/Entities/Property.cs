﻿namespace Nestin.Core.Entities
{
    public class Property : BaseEntity<string>
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string OwnerId { get; set; }
        public int PropertyTypeId { get; set; }
        public int LocationId { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string? SafteyInfo { get; set; }
        public string? HouseRules { get; set; }
        public string? CancellationPolicy { get; set; }
        public virtual AppUser Owner { get; set; }
        public virtual Location Location { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual ICollection<PropertyPhoto> PropertyPhotos { get; set; } = new HashSet<PropertyPhoto>();
        public virtual ICollection<PropertyGuest> PropertyGuests { get; set; } = new HashSet<PropertyGuest>();
        public virtual ICollection<PropertyFee> PropertyFees { get; set; } = new HashSet<PropertyFee>();
    }
}
