using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.HostUpgradeRequests;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    public class HostUpgradeRequestsController : BaseController
    {
        public HostUpgradeRequestsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpPost]
        [Authorize(Roles = "Guest")]
        [EndpointSummary("Create new Host upgrade request.")]
        [Consumes("multipart/form-data")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HostUpgradeRequestDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> Create([FromForm] HostUpgradeRequestCreateDto reqDto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpPatch("my-request")]
        [Authorize(Roles = "Guest")]
        [EndpointSummary("Allow users to update their own Host upgrade request.")]
        [Consumes("multipart/form-data")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HostUpgradeRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> UpdateMyRequest([FromBody] HostUpgradeRequestUpdateDto updateDto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpGet("my-request")]
        [Authorize(Roles = "Guest")]
        [EndpointSummary("Allow users to fetch their own Host upgrade request.")]
        [Consumes("multipart/form-data")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HostUpgradeRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> GetMyRequest()
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpPatch("{id}/approve")]
        [Authorize(Roles = "Admin")]
        [EndpointSummary("Allow admins to approve Host upgrade request.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HostUpgradeRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> ApproveRequest([FromRoute] string id)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpPatch("{id}/reject")]
        [Authorize(Roles = "Admin")]
        [EndpointSummary("Allow admins to reject Host upgrade request.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HostUpgradeRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> RejectRequest(string id, [FromBody] HostUpgradeRequestRejectDto reqDto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [EndpointSummary("Allow admins to fetch Host upgrade requests.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HostUpgradeRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> GetAllRequests([FromQuery] HostUpgradeRequestFilterQueryParamsDto queryDto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }
    }
}
