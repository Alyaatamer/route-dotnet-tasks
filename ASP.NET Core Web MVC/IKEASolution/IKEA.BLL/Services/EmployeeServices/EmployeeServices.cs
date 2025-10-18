using AutoMapper;
using IKEA.BLL.Dto_s.EmployeeDto_s;
using IKEA.DAL.Models.Employee;
using IKEA.DAL.Reposatories.EmployeeRepo;
using IKEA.DAL.UOW;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public EmployeeServices( IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }


        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var employees = unitOfWork.EmployeeReposatory.GetAll().ToList();
            var employeesDto = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(employees);
            return employeesDto;
        }
          //=> mapper.Map<IQueryable<Employee>, IQueryable<EmployeeDto>>(_reposatory.GetAll());


        public EmployeeDetailsDto GetEmployeeById(int id)
          => mapper.Map<Employee, EmployeeDetailsDto>(unitOfWork.EmployeeReposatory.GetById(id));


        public int AddEmployee(CreatedEmployeeDto dto)
        {
            var Emp = mapper.Map<CreatedEmployeeDto, Employee>(dto);

            Emp.CreatedBy = 1;
            Emp.CreatedOn = DateTime.Now;
            Emp.LastModifiedBy = 2;
            Emp.LastModifiedOn = DateTime.Now;

             unitOfWork.EmployeeReposatory.Add(Emp);

            return unitOfWork.Complete();

        }
        public int UpdateEmployee(UpdatedEmployeeDto dto)
        {
            var Emp = mapper.Map<UpdatedEmployeeDto, Employee>(dto);

            Emp.LastModifiedBy = 2;
            Emp.LastModifiedOn = DateTime.Now;

            unitOfWork.EmployeeReposatory.Update(Emp);
            return unitOfWork.Complete();
        }
        public int DeleteEmployee(int id)
        {
            if (id != null)
            {
                unitOfWork.EmployeeReposatory.Delete(id);
                return unitOfWork.Complete();
            }
            else return 0;
        }

        public IEnumerable<EmployeeDto> GetSearchedEmployees(string? searchValue)
         => mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(unitOfWork.EmployeeReposatory.GetAll(searchValue).ToList());
    }
}
