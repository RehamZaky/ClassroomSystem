namespace Classroom.API.Domain.Entities
{
    public class AnswerExplanation
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public Answer? Answer { get; set; }
        public string Content { get; set; } = string.Empty;
        
    }
}
