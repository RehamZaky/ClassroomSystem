using Classroom.API.Application.DTO;

namespace Classroom.API.Application.Service.Users
{
    public interface IParentService
    {
        Task<ParentDTO> CreateParent(ParentDTO parentDTO);
    }
}
