namespace Classroom.API.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
