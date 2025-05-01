﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.Properties;
using Nestin.Core.Dtos.PropertyAmenities;
using Nestin.Core.Dtos.PropertyAvailabilities;
using Nestin.Core.Dtos.PropertyFees;
using Nestin.Core.Dtos.PropertyGuests;
using Nestin.Core.Dtos.Reviews;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class PropertiesController : BaseController
    {
        private readonly IServiceFactory _serviceFactory;
        public PropertiesController(IUnitOfWork unitOfWork, IServiceFactory serviceFactory) : base(unitOfWork)
        {
            _serviceFactory = serviceFactory;
        }

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
            return Ok(await _unitOfWork.PropertyRepository.GetFilteredPropertiesAsync(dto, CurrentUser));
        }

        [HttpPost("search")]
        [EndpointSummary("Smart search for properity.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PropertySearchResultDto), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> Search([FromBody] string query)
        {
            var dto = await _serviceFactory.PropertyFilterExtractorService.ExtractFiltersAsync(query);
            var propertiesResult = await _unitOfWork.PropertyRepository.GetFilteredPropertiesAsync(dto, CurrentUser);

            var result = new PropertySearchResultDto
            {
                Items = propertiesResult.Items,
                MetaData = propertiesResult.MetaData,
                SearchParams = dto,
            };

            return Ok(result);
        }

        [HttpGet("{id}")]
        [EndpointSummary("Fetch single property by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PropertyDetailsDto), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            string? role = null;

            if (CurrentUser is not null)
            {
                if (CurrentUser.IsInRole("Admin"))
                    role = "Admin";
                else if (CurrentUser.IsInRole("Host"))
                    role = "Host";
                else
                    role = "Guest";
            }

            var result = await _unitOfWork.PropertyRepository.GetPropertyDetailsAsync(id, CurrentUser);

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
            var result = await _unitOfWork.PropertyAmenityRepository.GetByPropertyIdAsync(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Guests")]
        [EndpointSummary("Fetch property guests by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyGuestDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetGuestsById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertyGuestRepository.GetByPropertyIdAsync(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Fees")]
        [EndpointSummary("Fetch property fees by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyFeeDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetFeesById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertyFeeRepository.GetByPropertyIdAsync(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Availabilities")]
        [EndpointSummary("Fetch property aviabilities by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyAvailabilityDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetAvailabilitiesById([FromRoute] string id, [FromQuery] PropertyAvailabilityQueryParamsDto dto)
        {
            var result = await _unitOfWork.PropertyAvailabilityRepository.GetByPropertyIdAsync(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Spaces")]
        [EndpointSummary("Fetch property spaces by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertyAmenityDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetSpacesById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.PropertySpaceRepository.GetByPropertyIdAsync(id, dto);

            return Ok(result);
        }

        [HttpGet("{id}/Reviews")]
        [EndpointSummary("Fetch property Reviews by id.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<ReviewDto>), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> GetReviewsById([FromRoute] string id, [FromQuery] GetAllQueryDto dto)
        {
            var result = await _unitOfWork.ReviewRepository.GetPropertyReviews(id, dto);

            return Ok(result);
        }

        [Authorize(Roles = "Host")]
        [HttpPost]
        [EndpointSummary("Create new property.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PropertyDto), StatusCodes.Status201Created)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> Create([FromBody] PropertyCreateDto dto)
        {
            var userId = CurrentUser.Id;

            var property = new Property
            {
                Title = dto.Title,
                Description = dto.Description,
                OwnerId = userId,
                PropertyTypeId = dto.PropertyTypeId,
                LocationId = dto.LocationId,
                PricePerNight = dto.PricePerNight,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                SafteyInfo = dto.SafteyInfo,
                HouseRules = dto.HouseRules,
                CancellationPolicy = dto.CancellationPolicy,
                IsActive = false,
                IsDeleted = false
            };

            _unitOfWork.PropertyRepository.Create(property);
            await _unitOfWork.SaveChangesAsync();
            return new ObjectResult(property.ToDto()) { StatusCode = 201 };
        }

        [Authorize(Roles = "Host,Admin")]
        [HttpPatch("{id}")]
        [EndpointSummary("Update existing property.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PropertyDto), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] PropertyUpdateDto dto)
        {
            var userId = CurrentUser.Id;
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(id);

            if (property == null || (CurrentUser.IsInRole("Host") && property.OwnerId != userId))
            {
                return NotFoundResponse();
            }

            // Update only non-null properties from DTO
            property.Title = dto.Title ?? property.Title;
            property.Description = dto.Description ?? property.Description;
            property.PropertyTypeId = dto.PropertyTypeId ?? property.PropertyTypeId;
            property.LocationId = dto.LocationId ?? property.LocationId;
            property.PricePerNight = dto.PricePerNight ?? property.PricePerNight;
            property.Latitude = dto.Latitude ?? property.Latitude;
            property.Longitude = dto.Longitude ?? property.Longitude;
            property.SafteyInfo = dto.SafteyInfo ?? property.SafteyInfo;
            property.HouseRules = dto.HouseRules ?? property.HouseRules;
            property.CancellationPolicy = dto.CancellationPolicy ?? property.CancellationPolicy;
            property.IsActive = (dto.IsActive.HasValue) ? dto.IsActive.Value : property.IsActive;

            _unitOfWork.PropertyRepository.Update(property);
            await _unitOfWork.SaveChangesAsync();
            return Ok(property.ToDto());
        }

        [Authorize(Roles = "Host,Admin")]
        [HttpDelete("{id}")]
        [EndpointSummary("delete an existing property.")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(id);

            if (property is null)
            {
                return NotFoundResponse();
            }

            property.IsDeleted = true;

            _unitOfWork.PropertyRepository.Update(property);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/restore")]
        [EndpointSummary("Restore deleted property (for Admin only).")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PropertyDto), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(List<string>))]
        public async Task<IActionResult> Restore([FromRoute] string id)
        {
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(id);

            if (property is null)
            {
                return NotFoundResponse();
            }

            property.IsDeleted = false;

            _unitOfWork.PropertyRepository.Update(property);
            await _unitOfWork.SaveChangesAsync();

            return Ok(property.ToDto());
        }
    }
}
