using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertySpaceItems;
using Nestin.Core.Dtos.PropertySpaces;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class PropertySpacesController : BaseController
    {
        public PropertySpacesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet("{id}/Items")]
        [EndpointSummary("Fetch property spaces items by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertySpaceItemDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetItemsBySpaceId([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertySpaceItemRepository.GetByPropertySpaceIdAsync(id, dto);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PropertySpaceCreateDto dto)
        {
            await CheckPropertyAuthority(dto.PropertyId);

            var newSpace = new PropertySpace
            {
                PropertyId = dto.PropertyId,
                Name = dto.Name,
                PropertySpaceTypeId = dto.PropertySpaceTypeId,
                IsShared = dto.IsShared
            };

            _unitOfWork.PropertySpaceRepository.Create(newSpace);
            await _unitOfWork.SaveChangesAsync();
            return new ObjectResult(newSpace.ToDto()) { StatusCode = 201 };
        }

        [HttpPatch("{id}")]
        public Task<IActionResult> Update([FromRoute] string id, [FromBody] PropertySpaceUpdateDto dto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> Delete([FromRoute] string id)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
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
