using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Services;

namespace Nestin.Infrastructure.Shared
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IServiceProvider _provider;
        private readonly IConfiguration _config;

        private ITokenService _tokenService;
        private IFileUploadManagementService _fileUploadManagementService;

        public ServiceFactory(IServiceProvider provider, IConfiguration config)
        {
            _provider = provider;
            _config = config;
        }

        public ITokenService TokenService => _tokenService ??= new TokenService(_config, _provider.GetRequiredService<IIdentityFactory>());
        public IFileUploadManagementService FileUploadManagementService => _fileUploadManagementService ??= new FileUploadManagementService(_provider.GetRequiredService<IUnitOfWork>(), _provider.GetRequiredService<IFileStorageService>());
    }
}
