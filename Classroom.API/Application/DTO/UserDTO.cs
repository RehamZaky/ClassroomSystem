using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.DTO
{
    public class UserDTO
    {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
            public string? Phone { get; set; }
            public UserType UserType { get; set; }
       
    }
}
