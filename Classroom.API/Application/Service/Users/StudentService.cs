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

        public async Task<StudentUpdateDTO> UpdateStudent(StudentUpdateDTO StudentDTO)
        {
            var StudentDb = await _unitOfWork.Repository<Student>().GetByIdAsync(StudentDTO.Id);
            if (StudentDb == null)
                throw new KeyNotFoundException();

            var userDb = await _unitOfWork.Repository<User>().GetByIdAsync(StudentDb.userId);
            if (userDb == null)
                throw new KeyNotFoundException();

            // _mapper.Map(StudentDTO,userDb);
            userDb.Email = StudentDTO.Email;
            userDb.Phone = StudentDTO.Phone;
            userDb.Name = StudentDTO.Name;
            userDb.UpdatedAt = DateTime.Now;

            await _unitOfWork.Repository<User>().UpdateAsync(userDb);


            //_mapper.Map(StudentDTO, StudentDb);
            StudentDb.Age = StudentDTO.Age;
            await _unitOfWork.Repository<Student>().UpdateAsync(StudentDb);
            return StudentDTO;

        }
    }
}
