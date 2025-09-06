using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task3
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.Property(c => c.ID).UseIdentityColumn(1, 1);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(500);

            builder.HasOne(c => c.Topic).WithMany(t => t.Courses).HasForeignKey(c => c.Top_ID);
        }
    }
}
