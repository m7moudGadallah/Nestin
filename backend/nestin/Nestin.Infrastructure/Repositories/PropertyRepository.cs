using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    public class PropertyRepository : GenericRepository<Property, string>, IPropertyRepository
    {
        public PropertyRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
