namespace Classroom.API.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int QuizId { get; set; }
        public Quiz? Quiz { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
