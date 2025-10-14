using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCApp.DAL.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Configurations
{
    internal class CourseConfigarions : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);
            builder.Property(c => c.Title).HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(500);
        }
    }
}
