using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.AmenityCategories;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class AmenityCategoriesController : BaseController
    {
        public AmenityCategoriesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all aminity categries.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<AmenityCategoryDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryDto queryDto)
        {
            var result = await _unitOfWork.AmenityCategoryRepository.GetAllAsync(queryDto, q => q.OrderBy(x => x.Id));

            var resultDto = new PaginatedResult<AmenityCategoryDto>
            {
                Items = result.Items.Select(x => x.ToDo()).ToList(),
                MetaData = result.MetaData
            };

            return Ok(resultDto);
        }
    }
}
