namespace Classroom.API.Domain.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TotalScore { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsOpen { get; set; }
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<QuizeCertification> Certifications { get; set; } = new List<QuizeCertification>();
        public List<UserQuizAttempt> QuizAttempts { get; set; } = new List<UserQuizAttempt>();

    }
}
