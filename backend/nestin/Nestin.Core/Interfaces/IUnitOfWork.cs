namespace Nestin.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IRegionRepository RegionRepository { get; }
        public ICountryRepository CountryRepository { get; }
        public IPropertyRepository PropertyRepository { get; }
        public IPropertyTypeRepository PropertyTypeRepository { get; }
        public IAmenityRepository AmenityRepository { get; }
        public IAmenityCategoryRepository AmenityCategoryRepository { get; }
        public IGuestTypeReposiotry GuestTypeReposiotry { get; }
        public IPropertyAmenityRepository PropertyAmenityRepository { get; }
        public Task SaveChangesAsync();
    }
}
