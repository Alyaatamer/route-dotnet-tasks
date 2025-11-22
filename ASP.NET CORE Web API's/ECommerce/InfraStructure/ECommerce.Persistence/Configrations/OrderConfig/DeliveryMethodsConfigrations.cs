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
    public class DeliveryMethodsConfigrations : IEntityTypeConfiguration<DeliveryMethod>
    {
        public void Configure(EntityTypeBuilder<DeliveryMethod> builder)
        {
            builder.ToTable("DeliveryMethods");
            builder.Property(D => D.Price).HasColumnType("decimal(8,2)");
            builder.Property(D => D.ShortName).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(D => D.Description).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
