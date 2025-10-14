using MVCApp.DAL.Contexts;
using MVCApp.DAL.Models.Student;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.StudentRepo
{
    public class StudentRepo : GenericRepo<Models.Student.Student>, IStudentRepo
    {
        private readonly ApplicationDbContext _context;

        public StudentRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
