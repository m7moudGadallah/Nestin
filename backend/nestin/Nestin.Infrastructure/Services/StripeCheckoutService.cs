using Microsoft.Extensions.Configuration;
using Nestin.Core.Interfaces;
using Stripe;
using Stripe.Checkout;

namespace Nestin.Infrastructure.Services
{
    class StripeCheckoutService : ICheckoutManagementService
    {
        private readonly StripeClient _stripeClient;
        private readonly string _successUrl;
        private readonly string _cancelurl;
        public StripeCheckoutService(StripeClient stripeClient, IConfiguration config)
        {
            _stripeClient = stripeClient;
            _successUrl = config["Stripe:SuccessUrl"];
            _cancelurl = config["Stripe:CancelUrl"];
        }

        public async Task<CreateCheckoutResult> CreateCheckoutSessionAsync(CheckoutOptions options)
        {
            var sessionService = new SessionService(_stripeClient);

            var sessionOptions = new SessionCreateOptions
            {
                CustomerEmail = options.Guest.Email,
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
            {
                new()
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(options.Pricing.TotalAmount * 100),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = options.Property.Title,
                            Description = $"Booking from {options.BookingPeriod.CheckInDate:d} to {options.BookingPeriod.CheckOutDate:d}",
                            Images = !string.IsNullOrEmpty(options.Property.MainPhotoUrl)
                                ? new List<string> { options.Property.MainPhotoUrl }
                                : null
                        }
                    },
                    Quantity = 1
                }
            },
                Mode = "payment",
                SuccessUrl = _successUrl,
                CancelUrl = _cancelurl,
                ClientReferenceId = options.BookingId,
                Metadata = options.Metadata
            };

            var session = await sessionService.CreateAsync(sessionOptions);

            return new CreateCheckoutResult
            {
                SessionId = session.Id,
                SessionUrl = session.Url,
                ExpiresAt = session.ExpiresAt
            };
        }

        public Task HandlePaymentWebhookAsync(string json, string signature)
        {
            throw new NotImplementedException();
        }
    }
}
