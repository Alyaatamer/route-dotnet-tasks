using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    [Table("Students")]
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [MaxLength(50)]
        public string FName { get; set; }

        [MaxLength(50)]
        public string? LName { get; set; }
        public string? Address { get; set; }

        [NotMapped]
        public int Age { get; set; }
        public int Dept_ID { get; set; }
        public Department Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
    }
}
