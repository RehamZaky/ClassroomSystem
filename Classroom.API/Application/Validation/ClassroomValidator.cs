using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class ClassroomValidator : AbstractValidator<Domain.Entities.Classroom>
    {
        public ClassroomValidator()
        {
            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("Classroom title is required.")
                .MaximumLength(150).WithMessage("Title must not exceed 150 characters.");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Classroom description is required.");

            RuleFor(c => c.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Price must be a positive number or zero.");
        }
    }
}
