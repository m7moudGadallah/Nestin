using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertySpaces;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertySpaceRepository : IGenericRepository<PropertySpace, string>
    {
        public Task<PaginatedResult<PropertySpaceDto>> GetByPropertyId(string propertyId, GetAllQueryDto dto);
    }
}
