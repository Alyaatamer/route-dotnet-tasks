using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Models.Orders
{
    public class Order : BaseEntity<Guid>
    {
        public Order() { }
        public Order(string userEmail, OrderAddress address, DeliveryMethod deliveryMethod, ICollection<OrderItem> items, decimal subtotal,string PaymentIntentId)
        {
            UserEmail = userEmail;
            Address = address;
            DeliveryMethod = deliveryMethod;
            Items = items;
            Subtotal = subtotal;
            this.PaymentIntentId = PaymentIntentId;
        }

        public string UserEmail { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTimeOffset.UtcNow.DateTime;
        public OrderAddress Address { get; set; } = null!;
        public DeliveryMethod DeliveryMethod { get; set; } = null!;

        [ForeignKey("DeliveryMethod")]
        public int DeliveryMethodId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public ICollection<OrderItem> Items { get; set; } = [];
        public decimal Subtotal { get; set; }
        public decimal GetTotal() => Subtotal + DeliveryMethod.Price;

        public string PaymentIntentId { get; set; } 

    }
}
