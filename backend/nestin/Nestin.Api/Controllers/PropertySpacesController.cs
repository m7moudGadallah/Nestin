using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertySpaceItems;
using Nestin.Core.Interfaces;
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
        public async Task<IActionResult> GetSpacesById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertySpaceItemRepository.GetByPropertySpaceIdAsync(id, dto);

            return Ok(result);
        }
    }
}
