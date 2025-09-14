using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }

        public Address EmpAddress { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
