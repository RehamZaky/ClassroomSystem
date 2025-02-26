using Classroom.API.Application.DTO;
using MathNet.Numerics.Distributions;
using NPOI.SS.Formula.Functions;

namespace Classroom.API.Application.Service.Users
{
    public interface IStudentService
    {
        Task<StudentDTO> CreateStudent(StudentDTO studentDTO);
        Task<StudentUpdateDTO> UpdateStudent(StudentUpdateDTO studentDTO);

        List<StudentDTO> GetAllStudents();

    }
}
