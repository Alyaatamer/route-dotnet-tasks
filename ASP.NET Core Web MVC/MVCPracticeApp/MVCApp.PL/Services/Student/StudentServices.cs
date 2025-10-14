using AutoMapper;
using MVCApp.BLL.Dto_s.Course;
using MVCApp.BLL.Dto_s.Student;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Services.Student
{
    public class StudentServices
    {
        private readonly IGenericRepo<DAL.Models.Student.Student> _repo;
        private readonly IMapper _mapper;

        public StudentServices(IGenericRepo<DAL.Models.Student.Student> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<StudentDto> GetAll()
        {
            var students = _repo.GetAll().ToList();
            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public StudentDto GetById(int id)
        {
            var student = _repo.GetById(id);
            return _mapper.Map<StudentDto>(student);
        }

        public int Add(CreatedStudentDto dto)
        {
            var student = _mapper.Map<DAL.Models.Student.Student>(dto);
            return _repo.Add(student);
        }

        public int Update(UpdatesStudentDto dto)
        {
            var student = _mapper.Map<DAL.Models.Student.Student>(dto);
            return _repo.Update(student);
        }

        public int Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
