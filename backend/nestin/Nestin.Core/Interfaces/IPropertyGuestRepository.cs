using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyGuestRepository
    {
        public Task<PaginatedResult<PropertyGuestsDto>> GetByPropertyId(string propertyId, GetAllQueryDto dto);
    }
}
