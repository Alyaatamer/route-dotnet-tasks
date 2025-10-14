using MVCApp.BLL.Dto_s.Instructor;
using MVCApp.BLL.Dto_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Services.Instructor
{
    public interface IInstructorServices
    {
        IEnumerable<InstructorDto> GetAll();
        InstructorDto GetById(int id);
        int Add(CreatedInstructor dto);
        int Update(UpdatedInstructor dto);
        int Delete(int id);
    }
}
