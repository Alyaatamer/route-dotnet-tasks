using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    [Table("Departments")]
    public class Department
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

        public int? ManagerId { get; set; }
        public Instructor Manager { get; set; }

    }
}
