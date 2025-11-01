using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class ServicesManger(IMapper mapper , IUnitOfWork unitOfWork) : IServicesManger
    {
        private readonly Lazy<IProductServices> LazyProductServices = new Lazy<IProductServices> (() => new ProductServices(unitOfWork,mapper));   
        public IProductServices ProductServices => LazyProductServices.Value;
    }
}
