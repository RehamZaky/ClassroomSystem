using Classroom.API.Application.DTO;
using Classroom.API.Application.Service.Users;
using Classroom.API.Application.Validation;
using Classroom.API.Domain.Entities;
using Classroom.API.Extentions.Customs.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Classroom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IParentService _parentService;

        public ParentController(IParentService parentService)
        {
            _parentService = parentService;
        }
        [HttpPost("CreateParent")]
        public async Task<IActionResult> CreateParent(ParentDTO parentDTO)
        {
           var validateResult = new UserValidator().Validate(parentDTO);
            if (validateResult.IsValid)
            {
                var parent = await _parentService.CreateParent(parentDTO);
                if (parent != null)
                {
                    return Ok(new ApiResponse<ParentDTO>(parent, 200, "Parent user created successfully"));
                }
                return BadRequest(new ApiResponse<ParentDTO>("User not added", 400));
            }
            var errors = new List<string>();
            foreach (var error in validateResult.Errors)
            {
                errors.Add(error.ErrorMessage);
            }
            return BadRequest(new ApiResponse<ParentDTO>("", 400, errors));

        }

        [HttpPost("UpdateParent")]
        public async Task<IActionResult> UpdateParent(ParentUpdateDTO parentDTO)
        {
            try
            {
                var validateResult = new UserValidator().Validate(parentDTO);
                if (validateResult.IsValid)
                {
                    var parentResponse = await _parentService.UpdateParent(parentDTO);
                    return Ok(new ApiResponse<ParentUpdateDTO>(parentResponse, 200, "Parent user updated successfully"));
                }
                var errors = new List<string>();
                foreach (var error in validateResult.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
                return BadRequest(new ApiResponse<ParentDTO>("", 400, errors));
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(new ApiResponse<ParentUpdateDTO>("User not found", 404));
            }

        }
    }
}
