using Classroom.API.Application.DTO;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class AdminValidation :AbstractValidator<AdminUserDTO>

    {
        public AdminValidation() { 
            RuleFor(s=> s.JobTitle).NotEmpty().WithMessage("Job title is required");
            RuleFor(s=> s.RegisterDate).NotNull().WithMessage("Register date is required");
            RuleFor(s=> s.UserDto).SetValidator(new UserValidator()).When(s=> s.UserDto != null);
        }
    }
}
