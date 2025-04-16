using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class BaseRepository
    {
        protected readonly AppDbContext _dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
