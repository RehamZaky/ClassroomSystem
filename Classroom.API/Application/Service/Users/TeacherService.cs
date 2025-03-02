using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;
using Classroom.API.Infrastructure.Presistance.Ropository;

namespace Classroom.API.Application.Service.Users
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITeacherRepository _teacherRepository;
        
        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper, ITeacherRepository teacherRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _teacherRepository = teacherRepository;

        }
        public async Task<List<TeacherUserDTO>> GetAllTeachers()
        {
           var teachers = await _teacherRepository.GetAllTeachers();
            List<TeacherUserDTO> teacherUsers = new List<TeacherUserDTO>();
            foreach (var user in teachers)
            {
                teacherUsers.Add(new TeacherUserDTO(user));
            }
            return teacherUsers;
        }

        public async Task<TeacherDTO> CreateTeacher(TeacherDTO teacherDTO)
        {
            var user = _mapper.Map<User>(teacherDTO);
            user.CreatedAt = DateTime.Now;
            var addedUser = await _unitOfWork.Repository<User>().AddAsync(user);
            if(addedUser == null)
            {
                return null;

            }


            var teacher = _mapper.Map<Teacher>(teacherDTO);
            teacher.userId = addedUser.Id;

           var addedTeacher = await _unitOfWork.Repository<Teacher>().AddAsync(teacher);
            teacherDTO.Password = "";
            return teacherDTO;
        }

        public async Task<TeacherUserDTO> UpdateTeacher(TeacherUserDTO teacherDTO)
        {
            //var user = _mapper.Map<User>(teacherDTO);
            var user = await _teacherRepository.GetUserById(teacherDTO.userId);
            if (user == null)
            { throw new KeyNotFoundException(); }

            user.UpdatedAt = DateTime.Now;
            await _unitOfWork.Repository<User>().UpdateAsync(user);
            

            user.teacher.Salary = teacherDTO.Salary;
            user.teacher.JobTitle = teacherDTO.JobTitle;

            await _unitOfWork.Repository<Teacher>().UpdateAsync(user.teacher);
            return teacherDTO;
        }
    }
}
