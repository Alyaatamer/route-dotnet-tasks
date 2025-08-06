using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name,double salary)
        {
            Id = id;
            Name = name; 
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nSalary : {Salary}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id,Name,Salary);
        }

        public bool Equals(Employee? other)
        {
            if(other is not null)
            {
                return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
            }
            return false;
        }
    }
}
