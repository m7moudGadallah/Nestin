using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertySpaceItems;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertySpaceItemRepository : IGenericRepository<PropertySpaceItem, int>
    {
        public Task<PaginatedResult<PropertySpaceItemDto>> GetByPropertySpaceId(string propertySpaceId, GetAllQueryDto dto);
    }
}
