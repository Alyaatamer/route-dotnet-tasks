using AutoMapper;
using AutoMapper.Execution;
using ECommerce.Domain.Models.Orders;
using ECommerce.Shared.DTO_s.OrderDto_s;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.MappingProfiles
{
    public class OrderPictureUrlResolver(IConfiguration configuration) : IValueResolver<OrderItem, OrderItemDto, string>
    {
        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.Product.PictureUrl))
            {
                return string.Empty;
            }
            else
            {
                var url = $"{configuration.GetSection("Urls")["BaseUrl"]}{source.Product.PictureUrl}";
                return url;
            }
        }
    }
}
