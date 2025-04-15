using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Properties;
using Nestin.Core.Interfaces;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class PropertiesController : BaseController
    {
        public PropertiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all properties.")]
        [EndpointDescription(
            "Returns paginated list of properties for search/homepage display.\n" +
            "Includes essential info + preview data (photos, price, rating).\n\n" +
            "### Key Features:\n" +
            "- Filter by location, dates, price range, capacity\n" +
            "- Sort by price or rating\n" +
            "- Paginated results\n\n" +
            "### Response includes:\n" +
            "- Basic property info\n" +
            "- Photos\n" +
            "- Price per night\n" +
            "- Average rating\n" +
            "- Location details\n\n" +
            "### Sort Options:\n" +
            "- `price_asc`: Price low to high\n" +
            "- `price_desc`: Price high to low\n" +
            "- `rating`: Highest rated first")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyListItemDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] FilterPropertyQueryParamsDto dto)
        {
            return Ok(await _unitOfWork.PropertyRepository.GetFilteredPropertiesAsync(dto));
        }

        [HttpGet("{id}")]
        [EndpointSummary("Fetch single property by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyListItemDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var result = await _unitOfWork.PropertyRepository.GetPropertyDetails(id);

            if (result is null)
            {
                return NotFoundResponse();
            }

            return Ok(result);
        }
    }
}
