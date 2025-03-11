using Classroom.API.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Application.DTO
{
    public class StudentDTO :UserDTO
    {
        public int Age { get; set; }
        public int ParentId { get; set; }
    }

    public class StudentUpdateDTO : UserDTO
    {
        public int Id { get; set; }
        public int Age { get; set; }
    }

    public class StudentUserDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }

        public int? CourseId { get; set; } // ? null
        public CourseDTO? Course { get; set; }

        public UserType UserType { get; set; }
        public int Age { get; set; }

        public StudentUserDTO(User user)
        {
            Name = user.Name;
            Email = user.Email;
            Phone = user.Phone;
            UserType = user.UserType;
            Age = user.Students.Age;
            
        }

    }

}
