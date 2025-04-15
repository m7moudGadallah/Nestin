using Nestin.Core.Dtos.Properties;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyRepository : IGenericRepository<Property, string>
    {
        public Task<PaginatedResult<PropertyListItemDto>> GetFilteredPropertiesAsync(FilterPropertyQueryParamsDto queryDto);
    }
}
