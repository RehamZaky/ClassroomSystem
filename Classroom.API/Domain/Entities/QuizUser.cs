namespace Classroom.API.Domain.Entities
{
    public class QuizUser
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public int QuizeId { get; set; }
        public Quiz? Quiz { get; set; }
    }
}
