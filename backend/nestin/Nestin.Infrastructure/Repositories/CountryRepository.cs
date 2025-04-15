using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class CountryRepository : GenericRepository<Country, int>, ICountryRepository
    {
        public CountryRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
