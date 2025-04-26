using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    [Authorize(Roles = "Host,Admin")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public class PropertyGuestsController : BaseController
    {
        public PropertyGuestsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpPost]
        [EndpointSummary("Create Property Guest.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestsDto), StatusCodes.Status201Created)]
        public Task<IActionResult> Create([FromBody] PropertyGuestCreateDto dto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpPatch]
        [EndpointSummary("Update Property Guest.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestsDto), StatusCodes.Status200OK)]
        public Task<IActionResult> Update([FromBody] PropertGuestUpdateDto dto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpDelete("{propertyId}/{guestTypeId}")]
        [EndpointSummary("delete an existing Property Guest.")]
        public Task<IActionResult> Delete([FromRoute] string propertyId, [FromRoute] string guestTypeId)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }
    }
}
