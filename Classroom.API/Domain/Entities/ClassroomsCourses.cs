namespace Classroom.API.Domain.Entities
{
    public class ClassroomsCourses
    {
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int ClassroomsId { get; set; }
        public Classroom? Classroom { get; set; }
    }
}
