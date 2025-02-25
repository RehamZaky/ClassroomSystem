namespace Classroom.API.Domain.Entities
{
    public class UserPermission
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User? User { get; set; }
        public Permission? Permission { get; set; }
    }
}
