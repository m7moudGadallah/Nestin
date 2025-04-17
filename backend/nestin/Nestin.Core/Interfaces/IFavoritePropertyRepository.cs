using Nestin.Core.Dtos;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IFavoritePropertyRepository : IBaseRepository
    {
        Task<PaginatedResult<FavoriteProperty>> GetAllByUserIdAsync(string userId, GetAllQueryDto queryDto);
        Task CreateAsync(string userId, string propertyId);
        Task DeleteAsync(string userId, string propertyId);
    }
}
