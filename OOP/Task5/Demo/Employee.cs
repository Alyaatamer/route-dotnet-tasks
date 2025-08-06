using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable<Employee>
    {
        private int v1;
        private string v2;
        private int v3;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int id {  get; set; }

        public string name { get; set; }

        public double salary { get; set; }

        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nSalary: {salary}";
        }

        public int CompareTo(Employee? other)
        {
            return this.salary.CompareTo(other.salary);
        }
    }
}
