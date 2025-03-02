using Classroom.API.Application.DTO;

namespace Classroom.API.Application.Service.Users
{
    public interface ITeacherService 
    {
        Task<TeacherDTO> CreateTeacher(TeacherDTO teacherDTO);
        Task<List<TeacherUserDTO>> GetAllTeachers();

    }
}
