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
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _AdminService;
        public AdminController(IAdminService AdminService)
        {
            _AdminService = AdminService;
        }

        [HttpGet("GetAllAdmins")]
        public async Task<IActionResult> GetAllAdmins()
        {
            var AdminsDTO = await _AdminService.GetAllAdmins();
            return Ok(new ApiResponse<List<AdminUserDTO>>(AdminsDTO, 200, "Get all Admins successfully"));
        }

        [HttpPost("CreateAdmin")]
        public async Task<IActionResult> CreateAdmin(AdminDTO AdminDTO)
        {
            var validateResult = new UserValidator().Validate(AdminDTO);
            if (validateResult.IsValid)
            {
                var Admin = await _AdminService.CreateAdmin(AdminDTO);
                return Ok(new ApiResponse<AdminDTO>(AdminDTO, 200, "Admin created successfully"));
            }
            var errors = new List<string>();
            foreach (var error in validateResult.Errors)
            {
                errors.Add(error.ErrorMessage);
            }
            return BadRequest(new ApiResponse<AdminDTO>("", 400, errors));

        }

        [HttpPost("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin(AdminUserDTO AdminDTO)
        {
            var validateResult = new AdminValidation().Validate(AdminDTO);
            if (validateResult.IsValid)
            {
                var Admin = await _AdminService.UpdateAdmin(AdminDTO);
                return Ok(new ApiResponse<AdminUserDTO>(Admin, 200, "Admin updated successfully"));
            }
            var errors = new List<string>();
            foreach (var error in validateResult.Errors)
            {
                errors.Add(error.ErrorMessage);
            }
            return BadRequest(new ApiResponse<AdminDTO>("", 400, errors));

        }
    }
}
