using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Entities
{
    public class PropertyAmenity
    {
        public int AmenityId { get; set; }
        public string PropertyId { get; set; }
        public virtual Amenity Amenity { get; set; }
        public virtual Property Property { get; set; }
    }
}
