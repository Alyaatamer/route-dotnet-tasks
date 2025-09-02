using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.Property(s => s.ID).UseIdentityColumn(1, 1);
            builder.Property(s => s.FName).HasMaxLength(50).IsRequired().HasColumnName("First Name");

            builder.Ignore(s => s.Age);

        }
    }
}
