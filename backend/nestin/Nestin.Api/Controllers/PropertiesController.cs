using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.Properties;
using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Dtos.PropertyFees;
using Nestin.Core.Dtos.PropertyGuests;
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
        [ProducesResponseType(typeof(PropertyDetailsDto), StatusCodes.Status200OK)]
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

        [HttpGet("{id}/Amenities")]
        [EndpointSummary("Fetch property amenities by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyAmenityDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetAmenitiesById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertyAmenityRepository.GetByPropertyId(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Guests")]
        [EndpointSummary("Fetch property guests by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyGuestsDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetGuestsById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertyGuestRepository.GetByPropertyId(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Fees")]
        [EndpointSummary("Fetch property fees by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyFeeDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetFeesById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertyFeeRepository.GetByPropertyId(id, dto);

            return Ok(result);
        }
    }
}
