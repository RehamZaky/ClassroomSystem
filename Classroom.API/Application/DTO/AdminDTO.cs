using Classroom.API.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Application.DTO
{
    
        public class AdminDTO : UserDTO
        {
            public string JobTitle { get; set; } = string.Empty;
            public DateTime RegisterDate { get; set; }
        }


        public class AdminUserDTO
        {
            public int UserId { get; set; }
            public string JobTitle { get; set; } = string.Empty;
            public DateTime RegisterDate { get; set; }

            public UserDTO UserDto { get; set; } = new UserDTO();

            public AdminUserDTO() { }

            public AdminUserDTO(User user)
            {
                UserId = user.Id;
                UserDto.Name = user.Name;
                UserDto.Email = user.Email;
                UserDto.Phone = user.Phone;
                UserDto.UserType = user.UserType;
                JobTitle = user.admin.JobTitle;
                RegisterDate = user.admin.RegisterDate;

            }

        }
    
}
