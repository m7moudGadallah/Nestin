using Microsoft.AspNetCore.Http;
using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IFileUploadManagementService
    {
        public Task<FileUpload> UploadAsync(IFormFile file);
        public Task RemoveFileAsync(string fileUploadId);
    }
}
