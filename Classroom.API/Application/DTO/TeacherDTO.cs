using Classroom.API.Domain.Entities;
using System.Threading.Tasks.Dataflow;

namespace Classroom.API.Application.DTO
{
    public class TeacherDTO : UserDTO
    {
        public string JobTitle { get; set; } = string.Empty;
        public double Salary { get; set; }
    }

    //public class TeacherUpdateDTO : UserDTO
    //{
    //    public int Id { get; set; }
    //    public string JobTitle { get; set; } = string.Empty;
    //    public double Salary { get; set; }
    //}

    public class TeacherUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public UserType UserType { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public double Salary { get; set; }
        public TeacherUserDTO(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            Phone = user.Phone;
            UserType = user.UserType;
            JobTitle = user.teacher.JobTitle;
            Salary = user.teacher.Salary;

        }

    }
}
