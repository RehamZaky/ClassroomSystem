namespace Classroom.API.Domain.Entities
{
    public class Payment
    {
    
            public int Id { get; set; }
            public int ClassroomId { get; set; }
            public int UserId { get; set; }
            public User? User { get; set; }
            public DateTime Date { get; set; }
            public decimal Total { get; set; }
            public decimal Tax { get; set; }
            public string Status { get; set; } = string.Empty;  
            public Classroom? Classroom { get; set; }
        }

    }

