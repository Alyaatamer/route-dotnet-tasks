using IKEA.DAL.Contexts;
using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.Reposatories.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            EmployeeReposatory = new EmployeeReposatory(context);
            DepartmentReposatory = new DepartmentReposatory(context);
        }
        public IEmployeeReposatory EmployeeReposatory { get; set; }
        public IDepartmentReposatory DepartmentReposatory { get; set; }

        public int Complete()
        {
            return context.SaveChanges();
        }
    }
}
