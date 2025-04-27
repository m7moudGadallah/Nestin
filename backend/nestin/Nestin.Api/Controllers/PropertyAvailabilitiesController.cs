using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    [Authorize(Roles = "Admin,Host")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public class PropertyAvailabilitiesController : BaseController
    {
        public PropertyAvailabilitiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpPost]
        [EndpointSummary("Create Property Availability.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status201Created)]
        public Task<IActionResult> Create([FromBody] PropertyAvailabilityCreateDto dto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpPatch]
        [EndpointSummary("Update Property Availability.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status200OK)]
        public Task<IActionResult> Update([FromBody] PropertyAvailabilityUpdateDto dto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Delete existing Property Availability.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _unitOfWork.PropertyAvailabilityRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }
    }
}
