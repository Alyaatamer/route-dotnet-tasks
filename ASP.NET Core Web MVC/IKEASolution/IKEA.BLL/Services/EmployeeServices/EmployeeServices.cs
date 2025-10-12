using AutoMapper;
using IKEA.BLL.Dto_s.EmployeeDto_s;
using IKEA.DAL.Models.Employee;
using IKEA.DAL.Reposatories.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.EmployeeServices
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeReposatory _reposatory;
        private readonly IMapper mapper;

        public EmployeeServices(IEmployeeReposatory reposatory , IMapper mapper)
        {
            _reposatory = reposatory;
            this.mapper = mapper;
        }



        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var employees = _reposatory.GetAll();
            var employeesDto = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(employees);
            return employeesDto;
        }
          //=> mapper.Map<IQueryable<Employee>, IQueryable<EmployeeDto>>(_reposatory.GetAll());


        public EmployeeDetailsDto GetEmployeeById(int id)
          => mapper.Map<Employee, EmployeeDetailsDto>(_reposatory.GetById(id));


        public int AddEmployee(CreatedEmployeeDto dto)
        {
            var Emp = mapper.Map<CreatedEmployeeDto, Employee>(dto);

            Emp.CreatedBy = 1;
            Emp.CreatedOn = DateTime.Now;
            Emp.LastModifiedBy = 2;
            Emp.LastModifiedOn = DateTime.Now;

            return _reposatory.Add(Emp);

        }
        public int UpdateEmployee(UpdatedEmployeeDto dto)
        {
            var Emp = mapper.Map<UpdatedEmployeeDto, Employee>(dto);

            Emp.LastModifiedBy = 2;
            Emp.LastModifiedOn = DateTime.Now;

            return _reposatory.Update(Emp);
        }
        public int DeleteEmployee(int id)
        {
            if( id != null) return _reposatory.Delete(id);
            else return 0;
        }

    }
}
