namespace Nestin.Core.Interfaces
{
    public interface IServiceFactory
    {
        public ITokenService TokenService { get; }
        public IFileUploadManagementService FileUploadManagementService { get; }
        public IBookingManagementService BookingManagementService { get; }
        public IPropertyFilterExtractorService PropertyFilterExtractorService { get; }
    }
}
