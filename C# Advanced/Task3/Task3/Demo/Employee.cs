using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public int deptId { get; set; }
        public Employee(int id,string name,double salary , int dept)
        {
            Id = id;        
            Name = name;
            Salary = salary;
            deptId = dept;
        }

        public override string ToString()
        {
            return $"{Id}  ||  {Name}  ||  {Salary}";
        }
    }
}
