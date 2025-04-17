using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyAvailabilityRepository : IGenericRepository<PropertyAvailability, int>
    {
        public Task<PaginatedResult<PropertyAvailabilityDto>> GetByPropertyIdAsync(string propertyId, PropertyAvailabilityQueryParamsDto queryDto);
    }
}
