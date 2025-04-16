using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Entities
{
    public class PropertyAvailability:BaseEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PropertyId { get; set; }
        public virtual Property Property { get; set; }
    }
}
