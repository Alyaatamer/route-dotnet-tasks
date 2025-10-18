using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.Reposatories.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.UOW
{
    public interface IUnitOfWork
    {
        public IEmployeeReposatory EmployeeReposatory { get; set; }
        public IDepartmentReposatory DepartmentReposatory { get; set; }

        public int Complete();


    }
}
