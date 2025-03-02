using AutoMapper;
using Classroom.API.Application.DTO;
using Classroom.API.Application.Repository.Interface;

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
        public async Task<List<TeacherDTO>> GetAllTeachers()
        {
           var teachers = await _teacherRepository.GetAllTeachers();
            List<TeacherDTO> teacherUsers = new List<TeacherDTO>();
            foreach (var user in teachers)
            {
                teacherUsers.Add(new TeacherDTO(user));
            }
            return teacherUsers;
        }
    }
}
