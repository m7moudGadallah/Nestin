using Microsoft.AspNetCore.Http;
using Nestin.Core.Validation;

namespace Nestin.Core.Dtos.HostUpgradeRequests
{
    public class HostUpgradeRequestUpdateDto
    {
        [ValidHostUpgradeDocumentType]
        public string? DocumentType { get; set; }
        [ValidHostUpgradeDocumentNumber]
        public string? DocumentNumber { get; set; }
        [AllowedImageExtensionsAttribute(new[] { ".jpg", ".jpeg", ".png", ".gif" }, ErrorMessage = "Only image files (.jpg, .jpeg, .png, .gif) are allowed.")]
        public IFormFile? FrontPhoto { get; set; }
        [AllowedImageExtensionsAttribute(new[] { ".jpg", ".jpeg", ".png", ".gif" }, ErrorMessage = "Only image files (.jpg, .jpeg, .png, .gif) are allowed.")]
        public IFormFile? BackPhoto { get; set; }
    }
}
