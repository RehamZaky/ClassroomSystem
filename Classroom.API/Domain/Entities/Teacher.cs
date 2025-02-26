using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Domain.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public int userId { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        public double Salary { get; set; }

    }
}

