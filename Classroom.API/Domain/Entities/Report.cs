namespace Classroom.API.Domain.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int QuizId { get; set; }
        public Quiz? Quiz { get; set; }
        public int UserId { get; set; } 
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
