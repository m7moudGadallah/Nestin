using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;

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
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] PropertyGuestCreateDto dto)
        {
            // Get property and verify ownership/access
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(dto.PropertyId);
            if (property == null)
            {
                return NotFoundResponse("Property not found");
            }

            // Authorization check
            if (!CurrentUser.IsInRole("Admin") && property.OwnerId != CurrentUser.Id)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new List<string> { "You don't have permission to add guests to this property" });
            }

            // Check if guest type already exists for this property
            var existingGuest = await _unitOfWork.PropertyGuestRepository
                .GetByPropertyAndGuestTypeAsync(dto.PropertyId, dto.GuestTypeId);

            if (existingGuest is not null)
            {
                return BadRequest(new List<string> {
                    "This property already has a configuration for this guest type"
                });
            }

            var newGuest = new PropertyGuest
            {
                PropertyId = dto.PropertyId,
                GuestTypeId = dto.GuestTypeId,
                GuestCount = dto.GuestCount
            };

            _unitOfWork.PropertyGuestRepository.Create(newGuest);
            await _unitOfWork.SaveChangesAsync();

            var createdGuest = await _unitOfWork.PropertyGuestRepository
                .GetByPropertyAndGuestTypeAsync(dto.PropertyId, dto.GuestTypeId);

            return new ObjectResult(createdGuest?.ToDto()) { StatusCode = 201 };
        }

        [HttpPatch]
        [EndpointSummary("Update Property Guest.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromBody] PropertGuestUpdateDto dto)
        {
            // Get property and verify ownership/access
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(dto.PropertyId);
            if (property == null)
            {
                return NotFoundResponse("Property not found");
            }

            // Authorization check
            if (!CurrentUser.IsInRole("Admin") && property.OwnerId != CurrentUser.Id)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new List<string> { "You don't have permission to update guests for this property" });
            }

            // Get existing guest configuration
            var existingGuest = await _unitOfWork.PropertyGuestRepository
                .GetByPropertyAndGuestTypeAsync(dto.PropertyId, dto.GuestTypeId);

            if (existingGuest == null)
            {
                return NotFoundResponse("Guest configuration not found for this property");
            }

            existingGuest.GuestCount = dto.GuestCount;

            _unitOfWork.PropertyGuestRepository.Update(existingGuest);
            await _unitOfWork.SaveChangesAsync();

            return Ok(existingGuest.ToDto());
        }

        [HttpDelete("{propertyId}/{guestTypeId}")]
        [EndpointSummary("delete an existing Property Guest.")]
        public Task<IActionResult> Delete([FromRoute] string propertyId, [FromRoute] string guestTypeId)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }
    }
}
