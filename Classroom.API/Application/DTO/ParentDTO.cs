namespace Classroom.API.Application.DTO
{
    public class ParentDTO:UserDTO
    {
        public int Age { get; set; }

    }

    public class ParentUpdateDTO : UserDTO
    {
        public int Id { get; set; }
        public int Age { get; set; }

    }
}
