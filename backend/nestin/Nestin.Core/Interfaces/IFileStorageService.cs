using Microsoft.AspNetCore.Http;

namespace Nestin.Core.Interfaces
{
    public interface IFileStorageService
    {
        public Task<string> SaveFileAsync(IFormFile file);
        public Task DeleteFileAsync(string path);
    }
}
