namespace Classroom.API.Domain.Entities
{
    public class QuizeCertification
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Score { get; set; }
        public string Signature { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int QuizId { get; set; }
        public Quiz? Quiz { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
