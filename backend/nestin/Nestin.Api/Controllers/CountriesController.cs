using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.Countires;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class CountriesController : BaseController
    {
        public CountriesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all contries.")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var queryDto = new GetAllQueryDto
            {
                Page = page,
                PageSize = pageSize
            };

            var result = await _unitOfWork.CountryRepository.GetAllAsync(queryDto, q => q.OrderBy(x => x.Id));

            var resultDto = new PaginatedResult<CountryDto>
            {
                Items = result.Items.Select(x => x.ToDto()).ToList(),
                MetaData = result.MetaData
            };

            return Ok(resultDto);
        }
    }
}
