using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IAmenityRepository : IGenericRepository<Amenity, int>
    {
        public Task<bool> IsExistAsync(string propertyId, int amenityId);
    }
}
