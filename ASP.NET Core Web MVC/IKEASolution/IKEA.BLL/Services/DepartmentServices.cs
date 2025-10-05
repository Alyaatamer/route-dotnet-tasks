using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Factories.DepartmentFactory;
using IKEA.DAL.Reposatories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentReposatory _reposatory;
        public DepartmentServices(IDepartmentReposatory reposatory)
        {
            _reposatory = reposatory;
        }

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var departments = _reposatory.GetAll();

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
            var department = _reposatory.GetById(id);
            if( department == null) return null;

            var DepartmentDetails = department.ToEntity();

           return DepartmentDetails;

        }

        public int AddDepartment(CreatedDepartmentDto dto)
        {
            var dept = dto.ToDepartment();
            return _reposatory.Add(dept);
        }

        public int UpdateDepartment(UpdatedDepartmentDto dto)
        {
            var dept = dto.FromUpdatedDepartment();
            return _reposatory.Update(dept);
        }
        public int DeleteDepartment(int id)
        {
            return _reposatory.Delete(id);
        }

    }
}
