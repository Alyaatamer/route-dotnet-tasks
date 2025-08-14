using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Department(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Name} {Id}";
        }
    }
}
