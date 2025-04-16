using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertySpaceItemTypes;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class PropertySpaceItemTypesController : BaseController
    {
        public PropertySpaceItemTypesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        [EndpointSummary("Fetch all property space item types.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<PropertySpaceItemTypeDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryDto queryDto)
        {
            var result = await _unitOfWork.PropertySpaceItemTypeRepository.GetAllAsync(queryDto, q => q.OrderBy(x => x.Id));

            var resultDto = new PaginatedResult<PropertySpaceItemTypeDto>
            {
                Items = result.Items.Select(x => x.ToDto()).ToList(),
                MetaData = result.MetaData
            };

            return Ok(resultDto);
        }
    }
}
