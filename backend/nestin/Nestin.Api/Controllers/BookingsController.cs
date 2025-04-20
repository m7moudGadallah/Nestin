using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Bookings;
using Nestin.Core.Interfaces;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class BookingsController : BaseController
    {
        private IServiceFactory _serviceFactory;
        public BookingsController(IUnitOfWork unitOfWork, IServiceFactory serviceFactory) : base(unitOfWork)
        {
            _serviceFactory = serviceFactory;
        }

        [Authorize]
        [HttpGet]
        [EndpointSummary("Fetch all bookings.")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<BookingDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllBookingsQueryParamsDto queryDto)
        {
            var userId = CurrentUser.Id;
            var result = await _unitOfWork.BookingRepository.GetByUserIdAsync(userId, queryDto);
            return Ok(result);
        }

        [Authorize(Roles = "Guest,Host")]
        [HttpPost]
        [EndpointSummary("Create new booking bookings.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<BookingDto>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateBookingDto dto)
        {
            var userId = CurrentUser.Id;
            var createdBooking = await _serviceFactory.BookingManagementService.CreateBookingAsync(userId, dto);
            var bookingDto = await _unitOfWork.BookingRepository.GetBookingDetailsByIdAsync(createdBooking.Id);
            return new ObjectResult(bookingDto) { StatusCode = 201 };
        }
    }
}
