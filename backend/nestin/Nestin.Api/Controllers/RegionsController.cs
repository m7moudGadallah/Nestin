using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class RegionsController : BaseController
    {
        public RegionsController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        [HttpGet]
        [EndpointSummary("Fetch all regions.")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var queryDto = new GetAllQueryDto
            {
                Page = page,
                PageSize = pageSize
            };

            var result = await _unitOfWork.RegionRepository.GetAllAsync(queryDto);

            var resultDto = new PaginatedResult<RegionDto>
            {
                Items = result.Items.Select(x => x.ToDto()).ToList(),
                MetaData = result.MetaData
            };

            return Ok(resultDto);
        }
    }
}
