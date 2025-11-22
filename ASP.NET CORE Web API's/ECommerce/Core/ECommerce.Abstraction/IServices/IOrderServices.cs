using ECommerce.Shared.DTO_s.OrderDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Abstraction.IServices
{
    public interface IOrderServices
    {
        Task<OrderToReturnDto> CreateOrderAsync(OrderDto orderDto, string Email);
        Task<IEnumerable<DeliveryMethodDto>> GetDeliveryMethodsAsync();
        Task<IEnumerable<OrderToReturnDto>> GetAllOrdersAsync(string Email);
        Task<OrderToReturnDto> GetOrderByIdAsync(Guid orderId);
    }
}
