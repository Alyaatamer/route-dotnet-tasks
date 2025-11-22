using ECommerce.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Specifications
{
    public class OrderSpecifications : BaseSpecifications<Order,Guid>
    {
        public OrderSpecifications(string Email):base(o => o.UserEmail == Email)
        {
            AddIncludes(o => o.Items);
            AddIncludes(o => o.DeliveryMethod);

            AddOrderByDesc(o => o.OrderDate);

        }

        public OrderSpecifications(Guid Id) : base(o => o.Id == Id)
        {
            AddIncludes(o => o.Items);
            AddIncludes(o => o.DeliveryMethod);
        }
    }
}
