using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models.Department
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string code { get; set; }
        public string? Description { get; set; }
    }
}
