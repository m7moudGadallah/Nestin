using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyAmenityRepository
    {
        public Task<PaginatedResult<PropertyAmenityDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto);
        public Task<PropertyAmenity?> GetPropertyAmenityAsync(string propertyId, int amenityId);
        public void Create(PropertyAmenity entity);
        public void Delete(PropertyAmenity entity);
        public Task DeleteAsync(string propertyId, int amenityId);
    }
}
