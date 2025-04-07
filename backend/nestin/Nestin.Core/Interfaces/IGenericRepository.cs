using Nestin.Core.Dtos;
using Nestin.Core.Entities;
using Nestin.Core.Shared;
using System.Linq.Expressions;

namespace Nestin.Core.Interfaces
{
    public interface IGenericRepository<TEntity, T> where TEntity : BaseEntity<T>
    {
        public Task<PaginatedResult<TEntity>> GetAllAsync(GetAllQueryDto queryDto);
        public Task<PaginatedResult<TEntity>> GetAllAsync(GetAllQueryDto queryDto, params Expression<Func<TEntity, object>>[] includes);
        public Task<TEntity?> GetByIdAsync(T id);
        public Task<TEntity?> GetByIdAsync(T id, params Expression<Func<TEntity, object>>[] includes);
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public Task DeleteAsync(T id);
        public Task SaveChangesAsync();
    }
}
