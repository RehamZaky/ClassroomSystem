using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface IParentRepository: IRepository<Parent>
    {
        Task<List<User>> GetAllParentsWithUser();

        Task<User?> DeActivateParent(int id);
    }
}
