using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PropertySpaceTypeRepository : GenericRepository<PropertySpaceType, int>, IPropertySpaceTypeRepository
    {
        public PropertySpaceTypeRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
