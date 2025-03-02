using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface ITeacherRepository:IRepository<Teacher>
    {
        Task<List<User>> GetAllTeachers();

    }
}
