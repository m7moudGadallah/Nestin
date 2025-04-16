using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Locations;
using Nestin.Core.Interfaces;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class LocationsController : BaseController
    {
        public LocationsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all locations.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<LocationDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] LocationQueryParamsDto queryDto)
        {
            var result = await _unitOfWork.LocationRepository.GetFilteredLocationsAsync(queryDto);
            return Ok(result);
        }
    }
}
