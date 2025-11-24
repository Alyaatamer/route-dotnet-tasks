using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Domain.Exceptions;
using ECommerce.Domain.Models.Baskets;
using ECommerce.Domain.Models.Orders;
using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class PaymentServices(IConfiguration configuration, IBasketReposatory basketReposatory,IUnitOfWork unitOfWork,IMapper mapper) : IPaymentServices
    {
        public async Task<BasketDto> CreateOrUpdatePaymentIntentAsync(string basketid)
        {
            StripeConfiguration.ApiKey = configuration["StripeSettings:SecretKey"];
            var Basket = await basketReposatory.GetBasketAsync(basketid) ?? throw new BasketNotFoundException(basketid); 
            
            var ProductRepo = unitOfWork.GetRebosatory<Domain.Models.Products.Product,int>();

            foreach (var item in Basket.Items)
            {
                var Product = await ProductRepo.GetByIdAsync(item.Id) ?? throw new ProductNotFound(item.Id);
                item.Price = Product.Price;
            }

            var DeliveryMethod = await unitOfWork.GetRebosatory<DeliveryMethod, int>().GetByIdAsync(Basket.DeliveryMethodId.Value)
                                    ?? throw new DeliveryMethodNotFoundException(Basket.DeliveryMethodId.Value);

            Basket.ShippingPrice = DeliveryMethod.Price;

            var BasketAmount = (long)(Basket.Items.Sum(i => i.Quantity * i.Price) + DeliveryMethod.Price * 100);

            var PaymentServices = new PaymentIntentService();

            if(Basket.PaymentIntentId == null)
            {
                var options = new PaymentIntentCreateOptions
                {
                    Amount = BasketAmount,
                    Currency = "USD",
                    PaymentMethodTypes = ["card"],
                };
                var intent = await PaymentServices.CreateAsync(options);
                Basket.PaymentIntentId = intent.Id;
                Basket.ClientSecret = intent.ClientSecret;
            }
            else
            {
                var options = new PaymentIntentUpdateOptions
                {
                    Amount = BasketAmount,
                };
                await PaymentServices.UpdateAsync(Basket.PaymentIntentId, options);
            }
            await basketReposatory.CreateUpdateBasketAsync(Basket);
            return mapper.Map<CustomerBasket,BasketDto>(Basket);
        }
    }
}
