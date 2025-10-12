using IKEA.DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models.Employee
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }


        // Foreign Key
        public int? DepartmentId { get; set; }
        public Department.Department? Department { get; set; }

    }
}
