using IKEA.BLL.Dto_s.DepartmentDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentDto> GetAllDepartments();

        public DepartmentDetailsDto GetDepartmentById(int id);

        public int AddDepartment(CreatedDepartmentDto dto);

        public int UpdateDepartment(UpdatedDepartmentDto dto);

        public int DeleteDepartment(int id);
    }
}
