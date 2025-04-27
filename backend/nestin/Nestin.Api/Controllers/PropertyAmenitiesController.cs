using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyAmenities;
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
    public class PropertyAmenitiesController : BaseController
    {
        public PropertyAmenitiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpPost]
        [EndpointSummary("Create Property Amenity.")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(PropertyAmenityDto), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] PropertyAmenityCreateDto dto)
        {
            CheckPropertyAuthority(dto.PropertyId);

            var newAmenity = new PropertyAmenity
            {
                PropertyId = dto.PropertyId,
                AmenityId = dto.AmenityId
            };
            _unitOfWork.PropertyAmenityRepository.Create(newAmenity);
            await _unitOfWork.SaveChangesAsync();

            var amenity = await _unitOfWork.PropertyAmenityRepository.GetPropertyAmenityAsync(dto.PropertyId, dto.AmenityId);

            return new ObjectResult(amenity?.ToDto()) { StatusCode = 201 };
        }

        [HttpDelete("{propertyId}/{amenityId}")]
        [EndpointSummary("Delete existing Property Amenity.")]
        [ProducesResponseType(typeof(PropertyAmenityDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] string propertyId, int amenityId)
        {
            await CheckPropertyAuthority(propertyId);
            await _unitOfWork.PropertyAmenityRepository.DeleteAsync(propertyId, amenityId);
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
