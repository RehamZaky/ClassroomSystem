namespace Classroom.API.Domain.Entities
{
    public class AttendanceCertification
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public decimal Score { get; set; }
        public string Signature { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
       
    }
}
