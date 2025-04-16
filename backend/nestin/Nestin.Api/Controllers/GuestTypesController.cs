using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.GuestTypes;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class GuestTypesController : BaseController
    {
        public GuestTypesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all guest types.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<GuestTypesDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryDto queryDto)
        {
            var result = await _unitOfWork.GuestTypeReposiotry.GetAllAsync(queryDto, q => q.OrderBy(x => x.Id));

            var resultDto = new PaginatedResult<GuestTypesDto>
            {
                Items = result.Items.Select(x => x.ToDo()).ToList(),
                MetaData = result.MetaData
            };

            return Ok(resultDto);
        }
    }
}
