using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.Amenities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class AmenitiesController : BaseController
    {
        public AmenitiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all aminities.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<AmenityDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryDto queryDto)
        {
            var result = await _unitOfWork.AmenityRepository.GetAllAsync(queryDto, q => q.OrderBy(x => x.Id));

            var resultDto = new PaginatedResult<AmenityDto>
            {
                Items = result.Items.Select(x => x.ToDto()).ToList(),
                MetaData = result.MetaData
            };

            return Ok(resultDto);
        }
    }
}
