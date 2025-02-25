using Classroom.API.Application.DTO;

namespace Classroom.API.Application.Service.Classroom
{
    public interface IClassroomService
    {
        Task<ClassroomDTO> createClassroom(ClassroomDTO classroom);
    }
}
