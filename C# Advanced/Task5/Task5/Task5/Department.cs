using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }
        
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = sender as Employee;
            if (emp!=null && Staff.Contains(emp))
            {
                Staff.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} are removed from {DeptName} due to {e.Cause}");
            }
        }

        public void ShowStaff()
        {
            Console.WriteLine($"Staff in {DeptName}:");
            foreach (var emp in Staff)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Age: {emp.GetAge}, VacationStock: {emp.VacationStock}");
            }
        }
    }
}
