using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task3
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

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public int? ManagerId { get; set; }
        public virtual Instructor Manager { get; set; } = null!;

    }
}
