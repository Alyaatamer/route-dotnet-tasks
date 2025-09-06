using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task3
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
