using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Employee;
using IKEA.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Reposatories.EmployeeRepo
{
    public class EmployeeReposatory : GenericRepository<Employee>, IEmployeeReposatory
    {
        private readonly ApplicationDbContext _context;

        public EmployeeReposatory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
