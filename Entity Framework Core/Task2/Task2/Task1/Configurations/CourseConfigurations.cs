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
