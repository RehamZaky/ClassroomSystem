using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Repository.Interface
{
    public interface IParentRepository: IRepository<Parent>
    {
        List<Parent> GetAllParentsWithUser();

        Task<User?> DeActivateParent(int id);
    }
}
