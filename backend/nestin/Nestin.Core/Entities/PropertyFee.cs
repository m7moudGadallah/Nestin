using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Entities
{
    public class PropertyFee:BaseEntity<int>
    {
        public string PropertyId;
        public string Name;
      
        public decimal Amount { get; set; }

        public virtual Property Property { get; set; }
    }
}
