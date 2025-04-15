namespace Nestin.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IRegionRepository RegionRepository { get; }
        public ICountryRepository CountryRepository { get; }
        public Task SaveChangesAsync();
    }
}
