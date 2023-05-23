using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
using SharedResources.Models;
using Stripe.Checkout;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private static string s_wasmClientUrl = string.Empty;

        public CheckoutController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> CheckoutProcess([FromBody] Product product, [FromServices] IServiceProvider serviceProvider)
        {
            var referer = Request.Headers.Referer;
            s_wasmClientUrl = referer[0] ?? string.Empty;

            var server = serviceProvider.GetRequiredService<IServer>();

            var serverAddressesFeature = server.Features.Get<IServerAddressesFeature>();

            string? serverUrl = null;

            if (serverAddressesFeature is not null)
            {
                serverUrl = serverAddressesFeature.Addresses.FirstOrDefault();
            }

            if (serverUrl is not null)
            {
                var sessionId = await Checkout(product, serverUrl);
                var pubKey = _configuration["Stripe:PubKey"];

                var checkoutOrderResponse = new CheckoutOrderResponse()
                {
                    SessionId = sessionId,
                    PublishableKey = pubKey
                };

                return Ok(checkoutOrderResponse);
            }

            return StatusCode(500);
        }

        [NonAction]
        public async Task<string> Checkout(Product product, string serverUrl)
        {
            var options = new SessionCreateOptions
            {
                SuccessUrl = $"{serverUrl}/checkout/success?sessionId=" + "{CHECKOUT_SESSION_ID}",
                CancelUrl = s_wasmClientUrl + "failed",
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = new List<SessionLineItemOptions>
                {
                    new ()
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = product.Price,
                            Currency = "EUR",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = product.Name,
                                Description = product.Description,
                                Images = new List<string>
                                {
                                    product.ImageUrl ?? string.Empty
                                }
                            }
                        },
                        Quantity = 1
                    }
                },
                Mode = "subscription"    // this Mode (subscription) is for recurring payments. Change to "payment" for one-time payments.
            };

            var service = new SessionService();
            Session session = await service.CreateAsync(options);

            return session.Id;
        }

        [HttpGet("success")]
        public ActionResult Success(string sessionId)
        {
            var sessionService = new SessionService();
            var session = sessionService.Get(sessionId);

            // Can be saved to database
            var total = session.AmountTotal;
            var customerEmail = session.CustomerEmail;

            return Redirect(s_wasmClientUrl + "success");
        }
    }
}
