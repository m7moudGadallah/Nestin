using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;


namespace Nestin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritePropertiesController : ControllerBase
    {
        private readonly IFavoritePropertyRepository _favoritePropertyRepository;

        public FavoritePropertiesController(IFavoritePropertyRepository favoritePropertyRepository)
        {
            _favoritePropertyRepository = favoritePropertyRepository;
        }

        // POST: api/FavoriteProperties
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FavoritePropertiesDto dto)
        {
            try
            {
                await _favoritePropertyRepository.CreateAsync(dto.UserId, dto.PropertyId);
                return Ok(new { message = "Property added to favorites." });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE: api/FavoriteProperties
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] FavoritePropertiesDto dto)
        {
            try
            {
                await _favoritePropertyRepository.DeleteAsync(dto.UserId, dto.PropertyId);
                return Ok(new { message = "Property removed from favorites." });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

       
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAll(string userId, [FromQuery] string PropertyId)
        {
            var favorites = await _favoritePropertyRepository.GetAllByUserIdAsync(userId, PropertyId);
            var dtoList = favorites.ToDtoList();
            return Ok(dtoList);
        }
    }
}
    

