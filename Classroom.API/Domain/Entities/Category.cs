using NPOI.POIFS.Properties;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Classroom.API.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Category? Parent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [IgnoreDataMember]
        [JsonIgnore]
        public ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();
       // public ICollection<Course> Courses { get; set; } = new List<Course>();


    }
}
