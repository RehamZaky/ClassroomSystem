namespace Classroom.API.Domain.Entities
{
    public class Discussion
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int CreatorId { get; set; }
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User? Creator { get; set; }
    }
}
