using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.UserProfilesDto;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    [Authorize]
    public class UserProfileController : BaseController
    {
        public UserProfileController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }


        [HttpGet()]
        [EndpointSummary("Get UserProfile Info.")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetByUserId()
        {
            var userId = CurrentUser.Id;
            var userProfile = await _unitOfWork.UserProfileRepository.GetByUserIdAsync(userId);

            return Ok(userProfile);

        }


        [HttpPut()]
        [EndpointSummary("Update UserProfile Info.")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateByUserId([FromBody] UserprofileEditDto dto)
        {

            var userId = CurrentUser.Id;
            await _unitOfWork.UserProfileRepository.UpdateByUserId(userId, dto);
            return NoContent();
        }
    }
}