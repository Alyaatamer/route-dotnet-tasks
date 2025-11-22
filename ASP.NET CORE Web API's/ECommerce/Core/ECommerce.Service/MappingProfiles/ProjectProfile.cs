using AutoMapper;
using ECommerce.Domain.Models.Baskets;
using ECommerce.Domain.Models.Orders;
using ECommerce.Domain.Models.Products;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Shared.DTO_s;
using ECommerce.Shared.DTO_s.BasketDto_s;
using ECommerce.Shared.DTO_s.IdentityDto_s;
using ECommerce.Shared.DTO_s.OrderDto_s;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.MappingProfiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile(IConfiguration configuration)
        {
            #region Product
            CreateMap<Product, ProductDTO>()
                    .ForMember(dist => dist.BrandName, options => options.MapFrom(scr => scr.Brand.Name))
                    .ForMember(dist => dist.TypeName, options => options.MapFrom(scr => scr.Type.Name))
                    .ForMember(dist => dist.PictureURL, options => options.MapFrom(new PictureUrlResolver(configuration)));

            CreateMap<ProductBrand, BrandDTO>();

            CreateMap<ProductType, TypeDTO>();
            #endregion

            #region Basket
            CreateMap<CustomerBasket, BasketDto>().ReverseMap();
            CreateMap<BasketItem, BasketItemDto>().ReverseMap();
            #endregion

            #region User
            CreateMap<Address, AddressDto>().ReverseMap();
            #endregion

            #region Order
            CreateMap<AddressDto, OrderAddress>().ReverseMap();
            CreateMap<Order, OrderToReturnDto>().ForMember(d => d.DeliveryMethod, options => options.MapFrom(src => src.DeliveryMethod.ShortName));

            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(src => src.ProductName, options => options.MapFrom(src => src.Product.ProductName))
                .ForMember(src => src.PictureUrl, options => options.MapFrom(new OrderPictureUrlResolver(configuration)));

            CreateMap<DeliveryMethod, DeliveryMethodDto>().ReverseMap();
            #endregion
        }
    }
}
