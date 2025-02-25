using Classroom.API.Application.DTO;
using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

            RuleFor(u => u.Phone)
                .Matches(@"^\d{10,15}$").WithMessage("Invalid phone number format.");

            //RuleFor(u => u.RoleId)
            //    .GreaterThan(0).WithMessage("Role ID must be greater than 0.");
        }
    }
}
