using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Domain.Entities
{
    public class Parent
    {
        public int Id { get; set; } 
        public int Age { get; set; }
        public int userId { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
