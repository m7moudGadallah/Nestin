using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyPhotos;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    [Authorize(Roles = "Host,Admin")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public class PropertyPhotosController : BaseController
    {
        private IServiceFactory _serviceFactory;

        public PropertyPhotosController(IUnitOfWork unitOfWork, IServiceFactory serviceFactory) : base(unitOfWork)
        {
            _serviceFactory = serviceFactory;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [EndpointSummary("Upload property photos.")]
        [ProducesResponseType(typeof(List<PropertyPhotoDto>), StatusCodes.Status201Created)]
        public Task<IActionResult> Upload()
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpPost("reorder")]
        [EndpointSummary("Reoder property photos.")]
        [ProducesResponseType(typeof(List<PropertyPhotoDto>), StatusCodes.Status200OK)]
        public Task<IActionResult> Reorder([FromBody] PropertyPhotosReorderDto dto)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Reoder property photos.")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Task<IActionResult> Delete([FromRoute] string id)
        {
            return Task.FromResult<IActionResult>(NotImplementedResponse());
        }
    }
}
