using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertySpaceItemTypeRepository : GenericRepository<PropertySpaceItemType, int>, IPropertySpaceItemTypeRepository
    {
        public PropertySpaceItemTypeRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
