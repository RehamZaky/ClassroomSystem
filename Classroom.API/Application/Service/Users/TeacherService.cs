using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;
using Classroom.API.Domain.Entities;

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

    }
}
