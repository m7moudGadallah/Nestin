using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Interfaces;

namespace Nestin.Api.Controllers
{
    public class PaymentsController : BaseController
    {
        IServiceFactory _serviceFactory;
        public PaymentsController(IUnitOfWork unitOfWork, IServiceFactory serviceFactory) : base(unitOfWork)
        {
            _serviceFactory = serviceFactory;
        }

        [HttpPost("stripe/webhook")]
        public async Task<IActionResult> StripeWebHook()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            var signature = Request.Headers["Stripe-Signature"];

            await _serviceFactory.CheckoutManagementService.HandlePaymentWebhookAsync(json, signature);

            return Ok();
        }
    }
}
