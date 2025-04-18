﻿using Nestin.Core.Dtos;
using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IFavoritePropertyRepository : IBaseRepository
    {
        Task<PaginatedResult<FavoritePropertyDto>> GetAllByUserIdAsync(string userId, GetAllQueryDto queryDto);
        Task CreateAsync(string userId, string propertyId);
        Task DeleteAsync(string userId, string propertyId);
    }
}
