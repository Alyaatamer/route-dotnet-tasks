using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Table("Instructors")]
    public class Instructor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public virtual Department Department { get; set; } = null!;

        public virtual Department ManagedDepartment { get; set; } = null!;

        public virtual ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
