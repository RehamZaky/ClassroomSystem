using Classroom.API.Application.DTO;
using Classroom.API.Application.Service.Users;
using Classroom.API.Application.Validation;
using Classroom.API.Extentions.Customs.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Classroom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService) {
            _studentService = studentService;
        }
        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent(StudentDTO studentDTO)   
        {
            var validateResult = new UserValidator().Validate(studentDTO);
            if (validateResult.IsValid)
            {
                var student = await _studentService.CreateStudent(studentDTO);
                return Ok(new ApiResponse<StudentDTO>(student, 200, "Student created successfully"));
            }
            var errors = new List<string>();
            foreach (var error in validateResult.Errors)
            {
                errors.Add(error.ErrorMessage);
            }
            return BadRequest(new ApiResponse<StudentDTO>("", 400, errors));

        }

        [HttpPost("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent(StudentUpdateDTO StudentDTO)
        {
            try
            {
                var validateResult = new UserValidator().Validate(StudentDTO);
                if (validateResult.IsValid)
                {
                    var StudentResponse = await _studentService.UpdateStudent(StudentDTO);
                    return Ok(new ApiResponse<StudentUpdateDTO>(StudentResponse, 200, "Student user updated successfully"));
                }
                var errors = new List<string>();
                foreach (var error in validateResult.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
                return BadRequest(new ApiResponse<StudentDTO>("", 400, errors));
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(new ApiResponse<StudentUpdateDTO>("User not found", 404));
            }

        }

    }
}
