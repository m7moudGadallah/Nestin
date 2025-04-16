using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyAvailabilityRepository : IGenericRepository<PropertyAvailability, int>
    {
        public Task<PaginatedResult<PropertyAvailabilityDto>> GetByPropertyId(string propertyId, PropertyAvailabilityQueryParamsDto queryDto);
    }
}
