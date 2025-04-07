namespace Nestin.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public Task SaveChangesAsync();
    }
}
