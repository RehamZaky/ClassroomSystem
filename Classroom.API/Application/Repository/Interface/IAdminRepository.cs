using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface IAdminRepository:IRepository<Admin>
    {
       Task<List<User>> GetAllAdmins();

       Task<User?> GetUserById(int id);

        Task<User?> DeActivateAdmin(int id);
    }
}
