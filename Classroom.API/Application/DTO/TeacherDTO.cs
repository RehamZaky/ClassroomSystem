using Classroom.API.Domain.Entities;
using System.Threading.Tasks.Dataflow;

namespace Classroom.API.Application.DTO
{
    public class TeacherDTO : UserDTO
    {
        public string JobTitle { get; set; } = string.Empty;
        public double Salary { get; set; }
    }


    public class TeacherUserDTO
    {
        public int userId { get; set; }
         public string JobTitle { get; set; } = string.Empty;
        public double Salary { get; set; }

        public UserDTO UserDto { get; set; } = new UserDTO();

        public TeacherUserDTO() { }

        public TeacherUserDTO(User user)
        {
            userId = user.Id;
            UserDto.Name = user.Name;
            UserDto.Email = user.Email;
            UserDto.Phone = user.Phone;
            UserDto.UserType = user.UserType;
            JobTitle = user.teacher.JobTitle;
            Salary = user.teacher.Salary;

        }

    }
}
