using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task3
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
        public virtual Topic Topic { get; set; } = null!;

        public virtual ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public virtual ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
