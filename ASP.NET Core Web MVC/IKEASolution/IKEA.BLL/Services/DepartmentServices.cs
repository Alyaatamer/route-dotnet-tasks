using IKEA.DAL.Reposatories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services
{
    public class DepartmentServices
    {
        private readonly IDepartmentReposatory _reposatory;
        public DepartmentServices(IDepartmentReposatory reposatory)
        {
            _reposatory = reposatory;
        }
    }
}
