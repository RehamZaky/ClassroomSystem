namespace Classroom.API.Domain.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
        public bool IsTrue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
