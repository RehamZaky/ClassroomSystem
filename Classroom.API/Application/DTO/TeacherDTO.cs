using Classroom.API.Domain.Entities;

namespace Classroom.API.Application.DTO
{
    public class TeacherDTO :UserDTO
    {
        public string JobTitle { get; set; } = string.Empty;
        public double Salary { get; set; }

        public TeacherDTO(User user) { 
            Name = user.Name;
            Email = user.Email;
            Phone = user.Phone;
            UserType = user.UserType;   
            JobTitle = user.teacher.JobTitle;
            Salary = user.teacher.Salary;
        }
    }
}
