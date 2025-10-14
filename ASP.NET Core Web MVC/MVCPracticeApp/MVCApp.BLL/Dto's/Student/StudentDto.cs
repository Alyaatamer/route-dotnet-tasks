using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Dto_s.Student
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
       
        [EmailAddress]
        public string? Email { get; set; }

    }
}
