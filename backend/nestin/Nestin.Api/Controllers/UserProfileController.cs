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


        [HttpGet]
        [EndpointSummary("Get UserProfile Info.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserProfileDto), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetByUserId()
        {
            var userId = CurrentUser.Id;
            var userProfile = await _unitOfWork.UserProfileRepository.GetByUserIdAsync(userId);

            return Ok(userProfile);

        }


        [HttpPatch]
        [EndpointSummary("Update UserProfile Info.")]
        [Consumes("multipart/form-data")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserProfileDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateByUserId([FromForm] UpdateUserProfileDto dto)
        {
            var userId = CurrentUser.Id;

            // TODO: Check for file uploads (Photo)

            await _unitOfWork.UserProfileRepository.UpdateByUserId(userId, dto);
            await _unitOfWork.SaveChangesAsync();

            var userProfile = await _unitOfWork.UserProfileRepository.GetByUserIdAsync(userId);

            return Ok(userProfile);
        }
    }
}