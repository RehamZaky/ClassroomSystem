using Classroom.API.Application.DTO;
using Classroom.API.Application.Service.Users;
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
            return Ok(new ApiResponse<List<TeacherDTO>>(TeachersDTO, 200, "Get all Teachers successfully"));
        }
    }
}
