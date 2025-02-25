namespace Classroom.API.Domain.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
