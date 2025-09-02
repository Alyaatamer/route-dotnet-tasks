using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    [Table("Courses")]
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; }

    }
}
