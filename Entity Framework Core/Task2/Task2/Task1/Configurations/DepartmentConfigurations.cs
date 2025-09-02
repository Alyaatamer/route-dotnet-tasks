using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.Property(d => d.ID).UseIdentityColumn(1, 1);
            builder.Property(d => d.Name).HasMaxLength(50).IsRequired();

            builder.HasOne(d => d.Manager).WithOne(i => i.ManagedDepartment).HasForeignKey<Department>(d => d.ManagerId);
        }
    }
}
