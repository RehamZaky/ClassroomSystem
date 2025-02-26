using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Domain.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime RegisterDate { get; set; }
    }
}
