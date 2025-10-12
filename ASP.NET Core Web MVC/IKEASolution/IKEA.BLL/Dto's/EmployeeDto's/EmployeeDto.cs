using IKEA.DAL.Models.Employee;
using IKEA.DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dto_s.EmployeeDto_s
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public Gender Gender { get; set; }
        [Display(Name = "Employee Type")]
        public EmployeeType EmployeeType { get; set; }

        public string DepartmentName { get; set; }
    }
}
