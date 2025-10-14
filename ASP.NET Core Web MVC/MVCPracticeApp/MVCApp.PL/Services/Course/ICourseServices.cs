using MVCApp.BLL.Dto_s.Course;
using MVCApp.BLL.Dto_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Services.Course
{
    public interface ICourseServices
    {
        public IEnumerable<CourseDto> GetAll();
        public CourseDto GetById(int id);
        public int Add(CreatedCourseDto dto);
        public int Update(UpdatedCourse dto);
        public int Delete(int id);
    }
}
