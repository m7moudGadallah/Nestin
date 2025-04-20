using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos;
using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Interfaces;
using Nestin.Core.Shared;


namespace Nestin.Api.Controllers
{
    [Authorize]
    public class FavoritePropertiesController : BaseController
    {
        public FavoritePropertiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpPost]
        [EndpointSummary("Create new property favirate.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Create([FromBody] CreateFavoritePropertyDto dto)
        {
            var userId = CurrentUser.Id;
            await _unitOfWork.FavoritePropertyRepository.CreateAsync(userId, dto.PropertyId);
            return Created();
        }


        [HttpDelete("{propertyId:guid}")]
        [EndpointSummary("Delete exiting property favirate.")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete([FromRoute] string propertyId)
        {
            var userId = CurrentUser.Id;
            await _unitOfWork.FavoritePropertyRepository.DeleteAsync(userId, propertyId);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }


        [HttpGet()]
        [EndpointSummary("Get all property favirates.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<FavoritePropertyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryDto queryDto)
        {
            var userId = CurrentUser.Id;
            var result = await _unitOfWork.FavoritePropertyRepository.GetAllByUserIdAsync(userId, queryDto);

            return Ok(result);
        }
    }
}


