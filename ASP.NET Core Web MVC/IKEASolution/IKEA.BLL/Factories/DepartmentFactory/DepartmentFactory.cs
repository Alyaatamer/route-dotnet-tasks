using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.DAL.Models.Department;

namespace IKEA.BLL.Factories.DepartmentFactory
{
    public static class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department D, UpdatedDepartmentDto dto)
        {
            return new DepartmentDto()
            {
                Id = D.Id,
                Name = D.Name,
                Code = D.code,
                Description = D.Description
            };
        }
        
        public static DepartmentDetailsDto ToEntity(this Department D)
        {
            return new DepartmentDetailsDto(D);
        }

        public static Department ToDepartment(this CreatedDepartmentDto D)
        {
            return new Department()
            {
                Name = D.Name,
                code = D.Code,
                Description = D.Description,
                CreatedBy = 1,
                LastModifiedBy =1 ,
                CreatedOn = DateTime.Now,
                LastModifiedOn = DateTime.Now,
                IsDeleted = false,
            };
        }
        public static Department FromUpdatedDepartment(this UpdatedDepartmentDto D)
        {
            return new Department()
            {
                Id = D.Id,
                Name = D.Name,
                code = D.Code,
                Description = D.Description,
                CreatedBy = 1,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.Now,
                IsDeleted = false,
            };
        }
    }
}
