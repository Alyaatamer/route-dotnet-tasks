using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }

        List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = sender as Employee;
            if (emp != null && e.Cause == LayOffCause.NegativeVacationStock && Members.Contains(emp))
            {
                Members.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} are removed from {ClubName} due to {e.Cause}");
            }
        }

        public void ShowMembers()
        {
            Console.WriteLine($"Members in {ClubName}:");
            foreach (var emp in Members)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Age: {emp.GetAge}, VacationStock: {emp.VacationStock}");
            }
        }
    }
}
