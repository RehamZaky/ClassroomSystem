namespace Classroom.API.Domain.Entities
{
    public class UserClassroom
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        public DateTime EnrolledAt { get; set; }
    }
}
