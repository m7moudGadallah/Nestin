using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertyPhotos;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;

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
        public async Task<IActionResult> Upload([FromForm] PropertyPhotosUploadDto dto)
        {
            var userId = CurrentUser.Id;
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(dto.PropertyId);

            if (property is null)
            {
                return NotFoundResponse("Property not found");
            }

            if (property is not null && !(CurrentUser.IsInRole("Admin") ||
                property.OwnerId == userId))
            {
                return StatusCode(StatusCodes.Status403Forbidden,
           new List<string> { "You don't have permission to upload photos for this property" });
            }

            for (int i = 0; i < dto.Photos.Count; ++i)
            {
                var fileUpload = await _serviceFactory.FileUploadManagementService.UploadAsync(dto.Photos[i]);
                _unitOfWork.PropertyPhotoRepository.Create(new PropertyPhoto
                {
                    PhotoId = fileUpload.Id,
                    PropertyId = property.Id,
                    TouchedAt = DateTime.UtcNow.AddSeconds(i)
                });
            }

            await _unitOfWork.SaveChangesAsync();

            var propertyPhotos = await _unitOfWork.PropertyPhotoRepository.GetAllByPropertyIdASync(property.Id);

            return Ok(propertyPhotos.Select(x => x.ToDto()).ToList());
        }

        [HttpPost("reorder")]
        [EndpointSummary("Reoder property photos.")]
        [ProducesResponseType(typeof(List<PropertyPhotoDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Reorder([FromBody] PropertyPhotosReorderDto dto)
        {
            var property = await _unitOfWork.PropertyRepository.GetByIdAsync(dto.PropertyId);

            if (property is null)
            {
                return NotFoundResponse("Property not found");
            }

            // Authorization check
            if (!CurrentUser.IsInRole("Admin") && property.OwnerId != CurrentUser.Id)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new List<string> { "You don't have permission to reorder photos for this property" });
            }

            var existingPhotos = await _unitOfWork.PropertyPhotoRepository.GetAllByPropertyIdASync(property.Id);

            if (!existingPhotos.Any())
            {
                return NotFoundResponse("No photos found for this property");
            }

            // Validate all photo IDs in request exist for this property
            var existingPhotoIds = existingPhotos.Select(p => p.PhotoId).ToList();
            var invalidPhotoIds = dto.PhotoIds.Except(existingPhotoIds).ToList();
            if (invalidPhotoIds.Any())
            {
                return BadRequest(new List<string> {
            $"The following photo IDs don't belong to this property: {string.Join(", ", invalidPhotoIds)}"
        });
            }

            // Check if we have all photos in the request
            var missingPhotoIds = existingPhotoIds.Except(dto.PhotoIds).ToList();
            if (missingPhotoIds.Any())
            {
                return BadRequest(new List<string> {
            $"The following photos are missing from the reorder request: {string.Join(", ", missingPhotoIds)}"
        });
            }

            var photoDict = existingPhotos.ToDictionary(p => p.PhotoId);

            var now = DateTime.UtcNow;
            for (int i = 0; i < dto.PhotoIds.Count; i++)
            {
                var photo = photoDict[dto.PhotoIds[i]];
                photo.TouchedAt = now.AddSeconds(i);
                _unitOfWork.PropertyPhotoRepository.Update(photo);
            }

            await _unitOfWork.SaveChangesAsync();

            var propertyPhotos = await _unitOfWork.PropertyPhotoRepository.GetAllByPropertyIdASync(property.Id);

            return Ok(propertyPhotos.Select(x => x.ToDto()).ToList());
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
