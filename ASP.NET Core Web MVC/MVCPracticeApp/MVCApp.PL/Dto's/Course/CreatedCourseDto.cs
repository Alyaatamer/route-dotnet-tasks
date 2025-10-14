using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Dto_s.Course
{
    public class CreatedCourseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int InstructorId { get; set; }
    }
}
