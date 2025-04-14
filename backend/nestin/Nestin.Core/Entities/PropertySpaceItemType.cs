﻿namespace Nestin.Core.Entities
{
    public class PropertySpaceItemType : BaseEntity<int>
    {
        public string Name { get; set; }
        public int PropertySpaceTypeId { get; set; }
        public virtual PropertySpaceType PropertySpaceType { get; set; }
    }
}
