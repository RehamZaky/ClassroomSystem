namespace Classroom.API.Domain.Entities
{
    public class ClassroomsCourses
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
    }
}
