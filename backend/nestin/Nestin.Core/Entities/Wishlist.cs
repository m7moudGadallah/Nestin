using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Entities
{
    public class Wishlist
    {
        public string PropertyId { get; set; }
        public string GuestId { get; set; }

        public virtual Property Property { get; set; }
        public virtual AppUser Guest { get; set; }
    }
}
