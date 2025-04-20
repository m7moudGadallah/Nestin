namespace Nestin.Core.Interfaces
{
    public interface IServiceFactory
    {
        public ITokenService TokenService { get; }
        public IFileUploadManagementService FileUploadManagementService { get; }
    }
}
