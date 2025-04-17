using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Countires;
using Nestin.Core.Dtos.FavoriteProperties;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;
using Nestin.Core.Shared;
using System.Security.Claims;


namespace Nestin.Api.Controllers
{
    [Authorize]
    public class FavoritePropertiesController : BaseController
    {
        private readonly IFavoritePropertyRepository _favoritePropertyRepository;

        public FavoritePropertiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }



        // POST: api/FavoriteProperties
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FavoritePropertiesDto dto)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
               var result= await _favoritePropertyRepository.CreateAsync(userId, dto.PropertyId);
                var resultDto = new PaginatedResult<FavoritePropertiesDto>
                {
                    Items = result.Items.Select(x => x.ToDto()).ToList(),
                    MetaData = result.MetaData
                };
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

       
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] FavoritePropertiesDto dto)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _favoritePropertyRepository.DeleteAsync(dto.UserId, dto.PropertyId);
                return Ok(new { message = "Property removed from favorites." });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

       
       
        public async Task<IActionResult> GetAll( [FromQuery] string PropertyId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var favorites = await _favoritePropertyRepository.GetAllByUserIdAsync(userId, PropertyId);
            var dtoList = favorites.ToDtoList();
            return Ok(dtoList);
        }
    }
}
    

