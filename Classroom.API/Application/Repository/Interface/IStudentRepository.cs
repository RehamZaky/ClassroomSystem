using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface IStudentRepository :IRepository<Student>
    {
        List<Student> GetAllStudentsWithUsers();

        Student? DeActivateStudent(int id);
    }
}
