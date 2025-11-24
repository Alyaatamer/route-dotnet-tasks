using ECommerce.Domain.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistence.Configrations.OrderConfig
{
    public class OrderItemConfigrations : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.Property(OI => OI.Price).HasColumnType("decimal(8,2)");

            builder.OwnsOne(oi => oi.Product, p =>
            {
                p.Property(pp => pp.ProductId).HasColumnName("ProductId");
                p.Property(pp => pp.ProductName).HasColumnName("ProductName");
                p.Property(pp => pp.PictureUrl).HasColumnName("PictureUrl");
            });

        }
    }
}
