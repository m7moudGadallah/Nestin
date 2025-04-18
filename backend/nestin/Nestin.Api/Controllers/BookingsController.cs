using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Bookings;
using Nestin.Core.Interfaces;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class BookingsController : BaseController
    {
        public BookingsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        [Authorize]
        [HttpGet]
        [EndpointSummary("Fetch all bookings.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<BookingDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> GetAll([FromQuery] GetAllBookingsQueryParamsDto queryDto)
        {
            return Task.FromResult((IActionResult)StatusCode(StatusCodes.Status501NotImplemented, "This endpoint is not yet implemented"));
        }
    }
}
