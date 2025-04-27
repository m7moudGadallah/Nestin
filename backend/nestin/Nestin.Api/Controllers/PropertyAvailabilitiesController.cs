using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

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
        public async Task<IActionResult> Create([FromBody] PropertyAvailabilityCreateDto dto)
        {
            await CheckPropertyAuthority(dto.PropertyId);
            var newPropertyAvailability = new PropertyAvailability
            {
                PropertyId = dto.PropertyId,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                IsAvailable = true
            };

            _unitOfWork.PropertyAvailabilityRepository.Create(newPropertyAvailability);
            await _unitOfWork.SaveChangesAsync();
            return new ObjectResult(newPropertyAvailability.ToDto()) { StatusCode = 201 };
        }

        [HttpPatch("{id}")]
        [EndpointSummary("Update Property Availability.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PropertyAvailabilityUpdateDto dto)
        {
            var existingAvailability = await _unitOfWork.PropertyAvailabilityRepository.GetByIdAsync(id);

            if (existingAvailability is null)
            {
                return NotFoundResponse();
            }

            await CheckPropertyAuthority(existingAvailability.PropertyId);

            existingAvailability.StartDate = dto.StartDate.HasValue ? dto.StartDate.Value : existingAvailability.StartDate;
            existingAvailability.EndDate = dto.EndDate.HasValue ? dto.EndDate.Value : existingAvailability.EndDate;

            _unitOfWork.PropertyAvailabilityRepository.Update(existingAvailability);
            await _unitOfWork.SaveChangesAsync();
            return Ok(existingAvailability.ToDto());
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Delete existing Property Availability.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyGuestDto), StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var existingAvailability = await _unitOfWork.PropertyAvailabilityRepository.GetByIdAsync(id);

            if (existingAvailability is null)
            {
                return NotFoundResponse();
            }


            await CheckPropertyAuthority(existingAvailability.PropertyId);
            _unitOfWork.PropertyAvailabilityRepository.Delete(existingAvailability);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }

        private async Task CheckPropertyAuthority(string propertyId)
        {
            // Get property and verify ownership/access
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(propertyId);
            if (property == null)
            {
                throw new NotFoundException("Property not found");
            }

            // Authorization check
            if (!CurrentUser.IsInRole("Admin") && property.OwnerId != CurrentUser.Id)
            {
                throw new ForbiddenException("You don't have permission to add guests to this property");
            }
        }
    }
}
