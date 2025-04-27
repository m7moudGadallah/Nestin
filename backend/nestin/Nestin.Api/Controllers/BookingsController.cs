using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nestin.Core.Dtos.Bookings;
using Nestin.Core.Interfaces;
using Nestin.Core.Shared;

namespace Nestin.Api.Controllers
{
    public class BookingsController : BaseController
    {
        private IServiceFactory _serviceFactory;
        private IIdentityFactory _identityFactory;
        public BookingsController(IUnitOfWork unitOfWork, IServiceFactory serviceFactory, IIdentityFactory identityFactory) : base(unitOfWork)
        {
            _serviceFactory = serviceFactory;
            _identityFactory = identityFactory;
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
        [EndpointSummary("Create new booking.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BookingDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateBookingDto dto)
        {
            var userId = CurrentUser.Id;
            var createdBooking = await _serviceFactory.BookingManagementService.CreateBookingAsync(userId, dto);
            var bookingDto = await _unitOfWork.BookingRepository.GetBookingDetailsByIdAsync(createdBooking.Id);
            return new ObjectResult(bookingDto) { StatusCode = 201 };
        }

        [Authorize]
        [HttpPost("{bookingId:guid}/cancel")]
        [EndpointSummary("Cancel an exiting booking.")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Cancel([FromRoute] string bookingId)
        {
            var userId = CurrentUser.Id;
            var isAdmin = CurrentUser.Roles.Contains("Admin");

            await _serviceFactory.BookingManagementService.CancelBookingAsync(bookingId, userId, isAdmin);
            return NoContent();
        }

        [Authorize]
        [HttpPost("{bookingId}/checkout")]
        [EndpointSummary("Request for checkout session.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(PaginatedResult<CreateCheckoutResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Checkout([FromRoute] string bookingId)
        {
            var userId = CurrentUser.Id;

            var booking = await _unitOfWork.BookingRepository.GetByIdAsync(bookingId);

            if (booking is null || booking.UserId != userId)
            {
                return NotFoundResponse($"Booking with id [{bookingId}] is not found!");
            }

            var property = await _unitOfWork.PropertyRepository.GetPropertyDetailsAsync(booking.PropertyId);

            var user = await _identityFactory.UserManager.Users.FirstAsync(x => x.Id == userId);

            CheckoutOptions options = new CheckoutOptions
            {
                BookingId = bookingId,
                Guest = new UserInfo
                {
                    Id = userId,
                    Email = user.Email
                },
                Property = new PropertyInfo
                {
                    Id = property.Id,
                    Title = property.Title,
                    Description = property.Description,
                    MainPhotoUrl = property.Photos?.FirstOrDefault()?.PhotoUrl,
                    LocationName = property.Location.Name
                },
                BookingPeriod = new BookingPeriod
                {
                    CheckInDate = booking.CheckIn,
                    CheckOutDate = booking.CheckOut
                },
                Pricing = new PricingDetails
                {
                    PricePerNight = booking.PricePerNight,
                    TotalFees = booking.TotalFees
                }
            };

            var createSessoinResult = await _serviceFactory.CheckoutManagementService.CreateCheckoutSessionAsync(options);

            return Ok(createSessoinResult);
        }
    }
}
