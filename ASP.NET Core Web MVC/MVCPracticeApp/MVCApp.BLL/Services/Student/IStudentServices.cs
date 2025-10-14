using MVCApp.BLL.Dto_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Services.Student
{
    public interface IStudentServices
    {
        IEnumerable<StudentDto> GetAll();
        StudentDto GetById(int id);
        int Add(CreatedStudentDto dto);
        int Update(UpdatesStudentDto dto);
        int Delete(int id);
    }
}
