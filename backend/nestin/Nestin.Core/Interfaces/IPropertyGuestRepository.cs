using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyGuestRepository
    {
        public Task<PaginatedResult<PropertyGuestsDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto);
        public Task<PropertyGuest?> GetByPropertyAndGuestTypeAsync(string propertyId, int guestTypeId);
        public void Create(PropertyGuest entity);
        public void Update(PropertyGuest entity);
        public void Delete(PropertyGuest entity);
    }
}
