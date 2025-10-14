using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Models.Courses
{
    public class Course : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int InstructorId { get; set; }

        [ForeignKey (nameof(InstructorId))]
        public virtual Instructor.Instructor Instructor { get; set; }

        public virtual ICollection<Course> courses { get; set; } = new HashSet<Course>();


    }
}
