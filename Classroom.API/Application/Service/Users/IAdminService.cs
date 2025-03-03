using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.Service.Users
{
    public interface IAdminService
    {
        Task<AdminDTO> CreateAdmin(AdminDTO adminDTO);
        Task<AdminUserDTO> UpdateAdmin(AdminUserDTO adminDTO);


        Task<List<AdminUserDTO>> GetAllAdmins();

        Task<AdminUserDTO> DeActivateAdmin(int id);
    }
}
