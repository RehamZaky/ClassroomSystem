using Classroom.API.Application.DTO;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class TeacherValidation :AbstractValidator<TeacherUserDTO>
    {
        public TeacherValidation() {
            RuleFor(u => u.Salary).NotEmpty
                ().WithMessage("salary is required");
            RuleFor(u=> u.JobTitle).NotEmpty().WithMessage("Job title is required");

            RuleFor(u=> u.UserDto).SetValidator(new UserValidator()).When(u=> u.UserDto != null);
        }
    }
}
