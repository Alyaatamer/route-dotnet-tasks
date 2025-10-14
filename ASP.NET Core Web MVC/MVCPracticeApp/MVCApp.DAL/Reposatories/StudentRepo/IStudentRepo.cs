using MVCApp.DAL.Models.Student;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.StudentRepo
{
    public interface IStudentRepo : IGenericRepo<Student>
    {
    }
}
