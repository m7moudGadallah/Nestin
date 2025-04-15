using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Properties;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    public class PropertiesController : BaseController
    {
        public PropertiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpGet]
        [EndpointSummary("Fetch all properties.")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAll([FromQuery] FilterPropertyQueryParamsDto dto)
        {
            return Ok(await _unitOfWork.PropertyRepository.GetFilteredPropertiesAsync(dto));
        }
    }
}
