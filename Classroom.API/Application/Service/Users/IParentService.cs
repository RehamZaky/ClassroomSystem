using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Service.Users
{
    public interface IParentService
    {
        Task<ParentDTO> CreateParent(ParentDTO parentDTO);
        Task<ParentUpdateDTO> UpdateParent(ParentUpdateDTO parentDTO);
    }
}
