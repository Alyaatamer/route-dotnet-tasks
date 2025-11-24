using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Models.Baskets;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController(IServicesManger servicesManger) : ControllerBase
    {
        [Authorize]
        [HttpPost("{BasketId}")]
        public async Task<ActionResult<BasketDto>> CreateOrUpdatePaymentIntent(string BasketId)
        {
            var basket = await servicesManger.PaymentServices.CreateOrUpdatePaymentIntentAsync(BasketId);
            return Ok(basket);
        }
    }
}
