using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using MathNet.Numerics.Distributions;

namespace Classroom.API.Application.Service.Users
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StudentService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<StudentDTO> CreateStudent(StudentDTO studentDTO)
        {
            try
            {
                var user = _mapper.Map<User>(studentDTO);
                user.parent = null;
                user.CreatedAt = DateTime.Now;
                var newUser = await _unitOfWork.Repository<User>().AddAsync(user);
                if (newUser == null) { return null; }

                var student = _mapper.Map<Student>(studentDTO);
                student.userId = newUser.Id;

                await _unitOfWork.Repository<Student>().AddAsync(student);
                return studentDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
