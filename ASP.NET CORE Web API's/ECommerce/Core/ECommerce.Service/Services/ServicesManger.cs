using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Persistence.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class ServicesManger(IMapper mapper , IUnitOfWork unitOfWork , IBasketReposatory reposatory, UserManager<ApplicationUser> userManager,IConfiguration configuration) : IServicesManger
    {
        #region Product
        private readonly Lazy<IProductServices> LazyProductServices = new Lazy<IProductServices>(() => new ProductServices(unitOfWork, mapper));
        public IProductServices ProductServices => LazyProductServices.Value;
        #endregion


        #region Basket
        private readonly Lazy<IBasketServices> LazyBasketServices = new Lazy<IBasketServices>(() => new BasketServices(reposatory, mapper));
        public IBasketServices BasketServices => LazyBasketServices.Value;
        #endregion


        #region Authentication
        private readonly Lazy<IAuthenticationServices> LazyAuthenticationServices = new Lazy<IAuthenticationServices>(() => new AuthenticationServices(userManager, configuration, mapper));
        public IAuthenticationServices AuthenticationServices => LazyAuthenticationServices.Value;
        #endregion


        #region Order
        private readonly Lazy<IOrderServices> LazyOrderServices = new Lazy<IOrderServices>(() => new OrderServices(mapper, reposatory, unitOfWork));
        public IOrderServices OrderServices => LazyOrderServices.Value;

        private readonly Lazy<IPaymentServices> LazyPaymentServices = new Lazy<IPaymentServices>(() => new PaymentServices(configuration, reposatory, unitOfWork,mapper));
        public IPaymentServices PaymentServices => LazyPaymentServices.Value;
        #endregion

    }
}
