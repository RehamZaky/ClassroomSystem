namespace Classroom.API.Application.DTO
{
    public class ClassroomDTO
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool? IsActive { get; set; }
        public double Price { get; set; }
    }
}
