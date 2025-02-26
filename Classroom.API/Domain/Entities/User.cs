namespace Classroom.API.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public UserType UserType { get; set; }

        //   public int RoleId { get; set; }
        //   public Role? Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool IsActive { get; set; } = true;

        //public List<UserClassroom> UserClassrooms { get; set; } = new List<UserClassroom>();
        //public List<UserQuizAttempt> QuizAttempts { get; set; } = new List<UserQuizAttempt>();
        //public List<UserRole> UserRoles { get; set; } = new List<UserRole>();

        public Student Students { get; set; }
        public Teacher teacher { get; set; }
        public Admin admin { get; set; }
        public Parent parent { get; set; }
    }

    public enum UserType { Admin, Parent, Student, Teacher }
}
