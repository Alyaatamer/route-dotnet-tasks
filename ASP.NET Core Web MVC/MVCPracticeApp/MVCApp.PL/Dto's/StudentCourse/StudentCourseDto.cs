using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Dto_s.StudentCourse
{
    public class StudentCourseDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public DateTime EnteredOn { get; set; }
    }
}
