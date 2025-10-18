using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Dto_s.EmployeeDto_s;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeDto> GetAllEmployees();
        IEnumerable<EmployeeDto> GetSearchedEmployees(string? searchValue);

        public EmployeeDetailsDto GetEmployeeById(int id);

        public int AddEmployee(CreatedEmployeeDto dto);

        public int UpdateEmployee(UpdatedEmployeeDto dto);

        public int DeleteEmployee(int id);
    }
}
