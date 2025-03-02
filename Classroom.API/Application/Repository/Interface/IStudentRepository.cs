using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface IStudentRepository :IRepository<Student>
    {
        Task<List<User>> GetallUserStudent();
        Task<User?> GetUserById(int id);

        Task<User?> DeActivateStudent(int id);
    }
}
