using MVCApp.DAL.Contexts;
using MVCApp.DAL.Models.Instructor;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.InstructorRepo
{
    public class InstrucotrReposatory : GenericRepo<Instructor>, IInstrucotrReposatory
    {
        private readonly ApplicationDbContext _context;

        public InstrucotrReposatory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
