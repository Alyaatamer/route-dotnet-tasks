using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Factories.DepartmentFactory;
using IKEA.BLL.Services.DepartmentServices.DepartmentServices;
using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.DepartmentServices.DepartmentServices
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IUnitOfWork unitOfWork;

        public DepartmentServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var departments = unitOfWork.DepartmentReposatory.GetAll();

            var mappedDepartments = departments.Select(d => new DepartmentDto()
            {
                Id = d.Id,
                Name = d.Name,
                Code = d.code,
                Description = d.Description
            });

            return mappedDepartments;
        }
        public DepartmentDetailsDto GetDepartmentById(int id)
        {
            var department = unitOfWork.DepartmentReposatory.GetById(id);
            if( department == null) return null;

            var DepartmentDetails = department.ToEntity();

           return DepartmentDetails;

        }

        public int AddDepartment(CreatedDepartmentDto dto)
        {
            var dept = dto.ToDepartment();
            unitOfWork.DepartmentReposatory.Add(dept);
            return unitOfWork.Complete();
        }

        public int UpdateDepartment(UpdatedDepartmentDto dto)
        {
            var dept = dto.FromUpdatedDepartment();
            unitOfWork.DepartmentReposatory.Update(dept);
            return unitOfWork.Complete();
        }
        public int DeleteDepartment(int id)
        {
            unitOfWork.DepartmentReposatory.Delete(id);
            return unitOfWork.Complete();
        }

    }
}
