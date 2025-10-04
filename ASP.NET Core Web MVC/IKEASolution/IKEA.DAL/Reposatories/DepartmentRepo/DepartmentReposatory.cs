using IKEA.DAL.Contexts;

namespace IKEA.DAL.Reposatories.DepartmentRepo
{
    public class DepartmentReposatory : IDepartmentReposatory
    {
        private readonly ApplicationDbContext _context ;

        public DepartmentReposatory(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (!WithTracking)
            {
                return _context.Departments.AsNoTracking().ToList();
            }
            else
            {
                return _context.Departments.ToList();
            }
        }

        public Department GetById(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }

        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }

        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var department = GetById(id);
            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }

    }
}
