using Classroom.API.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classroom.API.Application.DTO
{
    public class StudentDTO :UserDTO
    {
        public int Age { get; set; }
        public int ParentId { get; set; }
    }

    public class StudentUpdateDTO : UserDTO
    {
        public int Id { get; set; }
        public int Age { get; set; }
    }
}
