using IKEA.DAL.Contexts;
using IKEA.DAL.Reposatories.GenericRepo;

namespace IKEA.DAL.Reposatories.DepartmentRepo
{
    public class DepartmentReposatory :GenericRepository<Department>, IDepartmentReposatory
    {
        private readonly ApplicationDbContext _context ;

        public DepartmentReposatory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        

    }
}
