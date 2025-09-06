using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task3
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.Property(s => s.ID).UseIdentityColumn(1, 1);
            builder.Property(s => s.FName).HasMaxLength(50).IsRequired().HasColumnName("First Name");

            builder.Ignore(s => s.Age);

            builder.HasOne(s => s.Department).WithMany(d => d.Students).HasForeignKey(s => s.Dept_ID);

        }
    }
}
