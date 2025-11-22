using ECommerce.Abstraction.IServices;
using ECommerce.Shared.DTO_s.OrderDto_s;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persentation.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class OrderController(IServicesManger servicesManger) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<OrderToReturnDto>> CreateOrder(OrderDto orderDto)
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var Order = await servicesManger.OrderServices.CreateOrderAsync(orderDto, Email);

            return Ok(Order);
        }

        [HttpGet("DeliveryMethods")]
        public async Task<ActionResult<IEnumerable<DeliveryMethodDto>>> GetDeliveryMethods()
        {
            var DeliveryMethods = await servicesManger.OrderServices.GetDeliveryMethodsAsync();
            return Ok(DeliveryMethods);
        }

        [HttpGet("AllOrders")]
        public async Task<ActionResult<IEnumerable<OrderToReturnDto>>> GetAllOrdersForUser()
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var Orders = await servicesManger.OrderServices.GetAllOrdersAsync(Email);
            return Ok(Orders);
        }

        [HttpGet]
        public async Task<ActionResult<OrderToReturnDto>> GetAllOrdersAsync(Guid id)
        {
            var Order = await servicesManger.OrderServices.GetOrderByIdAsync(id);
            return Ok(Order);
        }
    }
}
