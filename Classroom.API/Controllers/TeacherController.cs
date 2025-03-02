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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("GetAllTeachers")]
        public async Task<IActionResult> GetAllTeachers()
        {
            var TeachersDTO = await _teacherService.GetAllTeachers();
            return Ok(new ApiResponse<List<TeacherUserDTO>>(TeachersDTO, 200, "Get all Teachers successfully"));
        }

        [HttpPost("CreateTeacher")]
        public async Task<IActionResult> CreateTeacher(TeacherDTO teacherDTO)
        {
            var validateResult = new UserValidator().Validate(teacherDTO);
            if (validateResult.IsValid)
            {
                var teacher = await _teacherService.CreateTeacher(teacherDTO);
                return Ok(new ApiResponse<TeacherDTO>(teacher, 200, "Teacher created successfully"));
            }
            var errors = new List<string>();
            foreach (var error in validateResult.Errors)
            {
                errors.Add(error.ErrorMessage);
            }
            return BadRequest(new ApiResponse<TeacherDTO>("", 400, errors));

        }

        [HttpPost("UpdateTeacher")]
        public async Task<IActionResult> UpdateTeacher(TeacherUserDTO teacherDTO)
        {
            var validateResult = new TeacherValidation().Validate(teacherDTO);
            if (validateResult.IsValid)
            {
                var teacher = await _teacherService.UpdateTeacher(teacherDTO);
                return Ok(new ApiResponse<TeacherUserDTO>(teacher, 200, "Teacher updated successfully"));
            }
            var errors = new List<string>();
            foreach (var error in validateResult.Errors)
            {
                errors.Add(error.ErrorMessage);
            }
            return BadRequest(new ApiResponse<TeacherDTO>("", 400, errors));

        }

        [HttpPut("DeActivateTeacher")]
        public async Task<IActionResult> DeActivateTeacher(int userId)
        {
            try
            {
                var teacherDTO = await _teacherService.DeActivateTeacher(userId);
                return Ok(new ApiResponse<TeacherUserDTO>(teacherDTO, 200, "User updated successfully"));
            }
            catch (KeyNotFoundException e)
            {
                return BadRequest(new ApiResponse<TeacherUserDTO>("User not found", 404));
            }
        }
    }
}
