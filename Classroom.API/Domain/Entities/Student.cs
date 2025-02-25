using NPOI.POIFS.Properties;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get ; set; }
        public int userId { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        public int ParentId { get; set; }
        public Parent? Parent { get; set; }
    }
}

