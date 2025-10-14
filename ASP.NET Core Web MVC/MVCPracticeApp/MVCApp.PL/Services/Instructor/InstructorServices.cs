using AutoMapper;
using MVCApp.BLL.Dto_s.Instructor;
using MVCApp.BLL.Dto_s.Student;
using MVCApp.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.BLL.Services.Instructor
{
    public class InstructorServices
    {
        private readonly IGenericRepo<DAL.Models.Instructor.Instructor> _repo;
        private readonly IMapper _mapper;

        public InstructorServices(IGenericRepo<DAL.Models.Instructor.Instructor> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<InstructorDto> GetAll()
        {
            var ins = _repo.GetAll().ToList();
            return _mapper.Map<IEnumerable<InstructorDto>>(ins);
        }

        public InstructorDto GetById(int id)
        {
            var ins = _repo.GetById(id);
            return _mapper.Map<InstructorDto>(ins);
        }

        public int Add(CreatedInstructor dto)
        {
            var ins = _mapper.Map<DAL.Models.Instructor.Instructor>(dto);
            return _repo.Add(ins);
        }

        public int Update(UpdatedInstructor dto)
        {
            var ins = _mapper.Map<DAL.Models.Instructor.Instructor>(dto);
            return _repo.Update(ins);
        }

        public int Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
