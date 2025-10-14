using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Models
{
    public class StudentCourse : BaseEntity
    {

        public int StudentId { get; set; }
        public virtual Student.Student student { get; set; }


        public int CourseId { get; set; }
        public virtual Courses.Course course { get; set; }

        public DateTime EnteredOn { get; set; }
    }
}
