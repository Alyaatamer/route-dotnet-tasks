using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Domain.Exceptions;
using ECommerce.Domain.Models.Orders;
using ECommerce.Domain.Models.Products;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Service.Specifications;
using ECommerce.Shared.DTO_s.IdentityDto_s;
using ECommerce.Shared.DTO_s.OrderDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class OrderServices(IMapper mapper , IBasketReposatory basket , IUnitOfWork unitOfWork) : IOrderServices
    {
        public async Task<OrderToReturnDto> CreateOrderAsync(OrderDto orderDto, string Email)
        {
            var OrderAddress = mapper.Map<AddressDto,OrderAddress>(orderDto.Address);
            var Basket = await basket.GetBasketAsync(orderDto.BasketId) ?? throw new BasketNotFoundException(orderDto.BasketId);

            ArgumentNullException.ThrowIfNullOrEmpty(Basket.PaymentIntentId);
            var OrderRepo = unitOfWork.GetRebosatory<Order, Guid>();
            var Spec = new OrderWithPaymentIntentIdSpecifications(Basket.PaymentIntentId);
            var ExistingOrder = await OrderRepo.GetByIdWithSpecificationAsync(Spec);
            if (ExistingOrder != null)
            {
                OrderRepo.Delete(ExistingOrder);
            }

            List<OrderItem> OrderItems = [];
            var ProductRepo = unitOfWork.GetRebosatory<Product,int>();

            foreach (var item in Basket.Items)
            {
                var Product = await ProductRepo.GetByIdAsync(item.Id) ?? throw new ProductNotFound(item.Id);

                var OrderItem = new OrderItem()
                {
                   Product = new ProductItemOrdered
                   {
                       ProductId = Product.Id,
                       ProductName = Product.Name,
                       PictureUrl = Product.PictureURL,
                   },
                   Quantity = item.Quantity,
                   Price = Product.Price,
                };
                OrderItems.Add(OrderItem);
            }

            var DeliveryMethod = await unitOfWork.GetRebosatory<DeliveryMethod, int>().GetByIdAsync(orderDto.DeliveryMethodId)
                ?? throw new DeliveryMethodNotFoundException(orderDto.DeliveryMethodId);

            var Subtotal = OrderItems.Sum(item => item.Price * item.Quantity);
            var Order = new Order(Email, OrderAddress, DeliveryMethod, OrderItems, Subtotal,Basket.PaymentIntentId);

            unitOfWork.GetRebosatory<Order, Guid>().Add(Order);

            await unitOfWork.SaveChangesAsync();
            return mapper.Map<Order, OrderToReturnDto>(Order);
        }

        public async Task<IEnumerable<OrderToReturnDto>> GetAllOrdersAsync(string Email)
        {
            var Spec = new OrderSpecifications(Email);
            var Orders = await unitOfWork.GetRebosatory<Order, Guid>().GetAllWithSpecificationsAsync(Spec);

            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderToReturnDto>>(Orders);
        }

        public async Task<IEnumerable<DeliveryMethodDto>> GetDeliveryMethodsAsync()
        {
            var DeliveryMethods = await unitOfWork.GetRebosatory<DeliveryMethod, int>().GetAllAsync();

            return mapper.Map<IEnumerable<DeliveryMethod>, IEnumerable<DeliveryMethodDto>>(DeliveryMethods);
        }

        public async Task<OrderToReturnDto> GetOrderByIdAsync(Guid orderId)
        {
            var Spec = new OrderSpecifications(orderId);
            var Order = await unitOfWork.GetRebosatory<Order, Guid>().GetByIdWithSpecificationAsync(Spec);

            return mapper.Map<Order, OrderToReturnDto>(Order);
        }
    }
}
