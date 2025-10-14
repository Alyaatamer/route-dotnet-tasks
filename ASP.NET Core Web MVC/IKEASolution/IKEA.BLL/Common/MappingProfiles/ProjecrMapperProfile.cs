using AutoMapper;
using IKEA.BLL.Dto_s.EmployeeDto_s;
using IKEA.DAL.Models.Employee;

namespace IKEA.BLL.Common.MappingProfiles
{
    public class ProjecrMapperProfile : Profile
    {
        public ProjecrMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ForMember(d => d.DepartmentName,Options => Options.MapFrom(src => src.Department!=null ?src.Department.Name : "N/A" )).ReverseMap();


            CreateMap<Employee, EmployeeDetailsDto>().ForMember(d => d.DepartmentName, Options => Options.MapFrom(src => src.Department != null ? src.Department.Name : "N/A")).ReverseMap();


            CreateMap<CreatedEmployeeDto, Employee>()
                .ForMember(dest => dest.EmployeeType, Options => Options.MapFrom(scr => scr.EmployeeType))
                .ForMember(dest => dest.Gender, Options => Options.MapFrom(scr => scr.Gender));


            CreateMap<UpdatedEmployeeDto, Employee>().ReverseMap();


        }
    }
}
