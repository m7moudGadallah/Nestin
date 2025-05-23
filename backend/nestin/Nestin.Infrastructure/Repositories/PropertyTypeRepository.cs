﻿using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertyTypeRepository : GenericRepository<PropertyType, int>, IPropertyTypeRepository
    {
        public PropertyTypeRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
