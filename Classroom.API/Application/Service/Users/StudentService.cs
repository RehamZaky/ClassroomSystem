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
        private readonly IStudentRepository _studentRepository;
        public StudentService(IUnitOfWork unitOfWork,IMapper mapper,IStudentRepository studentRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _studentRepository = studentRepository;

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

        public async Task<StudentUpdateDTO> UpdateStudent(StudentUpdateDTO StudentDTO)
        {
            var userDb = await _studentRepository.GetUserById(StudentDTO.Id);
            if (userDb == null)
                throw new KeyNotFoundException();

            if (userDb.Students == null)
                throw new KeyNotFoundException();

            // _mapper.Map(StudentDTO,userDb);
            userDb.Email = StudentDTO.Email;
            userDb.Phone = StudentDTO.Phone;
            userDb.Name = StudentDTO.Name;
            userDb.UpdatedAt = DateTime.Now;

            await _unitOfWork.Repository<User>().UpdateAsync(userDb);


            //_mapper.Map(StudentDTO, StudentDb);
            userDb.Students.Age = StudentDTO.Age;
            await _unitOfWork.Repository<Student>().UpdateAsync(userDb.Students);
            return StudentDTO;

        }


        public async Task<List<StudentUserDTO>> GetAllStudents()
        {
             var userStudents = await _studentRepository.GetallUserStudent();
            List<StudentUserDTO> studentUsers = new List<StudentUserDTO>();
            foreach(var user in userStudents)
            {
                studentUsers.Add(new StudentUserDTO(user));
            }
            return studentUsers;
                //_mapper.Map<List<StudentUserDTO>>(students);  
        }

        public async Task<StudentDTO> DeActivateStudent(int id)
        {
           var student = await _studentRepository.DeActivateStudent(id);
            if (student == null)
                throw new KeyNotFoundException("Student not found");

             var studentDTO = _mapper.Map<StudentDTO>(student);
            //studentDTO.Phone = student.Phone;
            studentDTO.Age = student.Students.Age;

            return studentDTO;

        }

        public async Task<StudentUserDTO> EnrollStudentToCourse(int userId, int courseId)
        {
           var user = await _studentRepository.EnrollStudentToCourse(userId, courseId);
            if (user == null) throw new KeyNotFoundException();

            var studentUserDto = _mapper.Map<StudentUserDTO>(user);
           studentUserDto.Course = _mapper.Map<CourseDTO>(user.Course);

            return studentUserDto;
        }
    }
}
