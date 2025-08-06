using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class EmployeesNames : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return string.Compare(x?.name, y?.name);
        }
    }
}
