using MVCApp.DAL.Contexts;
using MVCApp.DAL.Models;
using MVCApp.DAL.Models.Instructor;
using MVCApp.DAL.Reposatories.GenericRepo;
using MVCApp.DAL.Reposatories.InstructorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.StudentCourseRepo
{
    public class StudCouRepo : GenericRepo<StudentCourse>, IStudCouRepo
    {
        private readonly ApplicationDbContext _context;

        public StudCouRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
