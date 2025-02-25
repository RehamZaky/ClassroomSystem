using Classroom.API.Application.DTO;
using Classroom.API.Application.Service.Classroom;
using Classroom.API.Extentions.Customs.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Classroom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomService classroomService;

        public ClassroomController(IClassroomService _classroomService)
        {
            classroomService = _classroomService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> post([FromForm] ClassroomDTO classroomDTO)
        {
            var classR = await classroomService.createClassroom(classroomDTO);
            return Ok(new ApiResponse<ClassroomDTO>(classR, 200, "Classroom Created Succussfully"));
        }
    }
}
