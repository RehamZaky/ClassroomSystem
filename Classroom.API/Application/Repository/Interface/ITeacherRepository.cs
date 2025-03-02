using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface ITeacherRepository:IRepository<Teacher>
    {
        Task<List<User>> GetAllTeachers();
        Task<User?> GetUserById(int id);
        Task<User?> DeActivateTeacher(int id);


    }
}
