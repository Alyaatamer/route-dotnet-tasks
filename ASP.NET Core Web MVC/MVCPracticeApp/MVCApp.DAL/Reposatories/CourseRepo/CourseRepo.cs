using MVCApp.DAL.Contexts;
using MVCApp.DAL.Reposatories.Course;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.Course
{
    public class CourseRepo : GenericRepo<Models.Courses.Course>, ICourseRepo
    {
        private readonly ApplicationDbContext _context;

        public CourseRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
