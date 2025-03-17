using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Classroom.API.Domain.Entities
{
    public class Classroom

    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool? IsActive { get; set; }
        public double Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


        // CategoryID
        [JsonIgnore]
        [IgnoreDataMember]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; } = new Category();
      //  public ICollection<Course> Course { get; set; }
      //  public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
       // public List<Discussion> Discussions { get; set; } = new List<Discussion>();
       // public List<UserClassroom> UserClassrooms { get; set; } = new List<UserClassroom>();





    }
}
