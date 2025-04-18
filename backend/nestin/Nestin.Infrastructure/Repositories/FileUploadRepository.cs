using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class FileUploadRepository : GenericRepository<FileUpload, string>, IFileUploadRepository
    {
        public FileUploadRepository(AppDbContext dbContext) : base(dbContext)
        { }
    }
}
