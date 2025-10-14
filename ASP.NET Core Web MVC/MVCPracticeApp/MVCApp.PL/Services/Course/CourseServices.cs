using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCApp.BLL.Dto_s.Course;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Services.Course
{
    public class CourseServices
    {
        private readonly IGenericRepo<DAL.Models.Courses.Course> _repo;
        private readonly IMapper _mapper;

        public CourseServices(IGenericRepo<DAL.Models.Courses.Course> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<CourseDto> GetAll()
        {
            var courses = _repo.GetAll().ToList();
            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        public CourseDto GetById(int id)
        {
            var course = _repo.GetById(id);
            return _mapper.Map<CourseDto>(course);
        }

        public int Add(CreatedCourseDto dto)
        {
            var course = _mapper.Map<DAL.Models.Courses.Course>(dto);
            return _repo.Add(course);
        }

        public int Update(UpdatedCourse dto)
        {
            var course = _mapper.Map<DAL.Models.Courses.Course>(dto);
            return _repo.Update(course);
        }

        public int Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
