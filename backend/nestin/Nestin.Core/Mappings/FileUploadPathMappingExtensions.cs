using Microsoft.Extensions.Configuration;

namespace Nestin.Core.Mappings
{
    public static class FileUploadPathMappingExtensions
    {
        private static string _baseUrl;

        public static void Init(IConfiguration configuration)
        {
            _baseUrl = configuration["AppSettings:BaseUrl"]?.TrimEnd('/');
        }

        public static string ToFullUrl(this string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath) || string.IsNullOrWhiteSpace(_baseUrl))
                return string.Empty;

            return $"{_baseUrl}/{relativePath.TrimStart('/')}";
        }
    }
}
