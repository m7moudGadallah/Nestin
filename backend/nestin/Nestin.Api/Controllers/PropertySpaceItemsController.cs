using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.PropertySpaceItems;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Core.Mappings;

namespace Nestin.Api.Controllers
{
    [Authorize(Roles = "Admin,Host")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public class PropertySpaceItemsController : BaseController
    {
        public PropertySpaceItemsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PropertySpaceItemCreateDto dto)
        {
            var newSpaceItem = new PropertySpaceItem
            {
                PropertySpaceItemTypeId = dto.PropertySpaceItemTypeId,
                PropertySpaceId = dto.PropertySpaceId,
                Quantity = dto.Quantity
            };

            _unitOfWork.PropertySpaceItemRepository.Create(newSpaceItem);
            await _unitOfWork.SaveChangesAsync();
            return new ObjectResult(newSpaceItem.ToDto()) { StatusCode = 201 };
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PropertySpaceItemUpdateDto dto)
        {
            var exitingItem = await _unitOfWork.PropertySpaceItemRepository.GetByIdAsync(id);

            if (exitingItem is null)
            {
                return NotFoundResponse();
            }

            exitingItem.PropertySpaceItemTypeId = dto.PropertySpaceItemTypeId.HasValue ? dto.PropertySpaceItemTypeId.Value : exitingItem.PropertySpaceItemTypeId;
            exitingItem.Quantity = dto.Quantity.HasValue ? dto.Quantity.Value : exitingItem.Quantity;


            _unitOfWork.PropertySpaceItemRepository.Update(exitingItem);
            await _unitOfWork.SaveChangesAsync();

            return Ok(exitingItem.ToDto());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var item = await _unitOfWork.PropertySpaceItemRepository.GetByIdAsync(id);

            if (item is null)
            {
                return NotFoundResponse();
            }

            _unitOfWork.PropertySpaceItemRepository.Delete(item);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }
    }
}
