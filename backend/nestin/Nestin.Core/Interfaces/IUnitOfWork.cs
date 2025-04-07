namespace Nestin.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IRegionRepository RegionRepository { get; }
        public Task SaveChangesAsync();
    }
}
