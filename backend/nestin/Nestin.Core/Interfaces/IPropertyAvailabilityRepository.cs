using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Entities;
using Nestin.Core.Shared;
using System.Linq.Expressions;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyAvailabilityRepository : IGenericRepository<PropertyAvailability, int>
    {
        public Task<List<PropertyAvailability>> GetAllAsync(Expression<Func<PropertyAvailability, bool>> filter);
        public Task<PaginatedResult<PropertyAvailabilityDto>> GetByPropertyIdAsync(string propertyId, PropertyAvailabilityQueryParamsDto queryDto);
        public void Delete(PropertyAvailability propertyAvailability);
    }
}
