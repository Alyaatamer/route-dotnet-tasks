using ECommerce.Domain.Models.Baskets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Abstraction.IServices
{
    public interface IPaymentServices
    {
        Task<BasketDto> CreateOrUpdatePaymentIntentAsync(string basketid);
    }
}
