using Nestin.Core.Dtos.Locations;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface ILocationRepository : IGenericRepository<Location, int>
    {
        public Task<PaginatedResult<LocationDto>> GetFilteredLocationsAsync(LocationQueryParamsDto queryDto);
    }
}
