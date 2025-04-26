﻿using Nestin.Core.Dtos;
using Nestin.Core.Entities;
using Nestin.Core.Shared;
using System.Linq.Expressions;

namespace Nestin.Core.Interfaces
{
    public interface IGenericRepository<TEntity, TKey> : IBaseRepository where TEntity : BaseEntity<TKey>
    {
        public Task<PaginatedResult<TEntity>> GetAllAsync(GetAllQueryDto queryDto, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
        public Task<PaginatedResult<TEntity>> GetAllAsync(GetAllQueryDto queryDto, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, params Expression<Func<TEntity, object>>[] includes);
        public Task<TEntity?> GetByIdAsync(TKey id);
        public Task<TEntity?> GetByIdAsync(TKey id, params Expression<Func<TEntity, object>>[] includes);
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public Task DeleteAsync(TKey id);
    }
}
