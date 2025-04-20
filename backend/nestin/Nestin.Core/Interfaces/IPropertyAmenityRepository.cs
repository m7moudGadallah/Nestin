using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyAmenityRepository
    {
        public Task<PaginatedResult<PropertySpaceDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto);
    }
}
