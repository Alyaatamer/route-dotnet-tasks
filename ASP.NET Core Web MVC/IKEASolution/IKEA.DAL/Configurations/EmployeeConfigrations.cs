using IKEA.DAL.Models.Employee;
using IKEA.DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Configurations
{
    public class EmployeeConfigrations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).HasColumnType("varchar(50)");
            builder.Property(e => e.Address).HasColumnType("varchar(150)");
            builder.Property(e => e.Salary).HasColumnType("decimal(10,3)");

            builder.Property(e => e.Gender).HasConversion((G) => G.ToString(),(gender) => (Gender)Enum.Parse(typeof(Gender),gender));
            builder.Property(e => e.EmployeeType).HasConversion((E) => E.ToString(),(Emp) => (EmployeeType)Enum.Parse(typeof(EmployeeType),Emp));

        }
    }
}
