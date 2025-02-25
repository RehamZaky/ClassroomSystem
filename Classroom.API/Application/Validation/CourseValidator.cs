using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("Course title is required.")
                .MaximumLength(200).WithMessage("Title must not exceed 200 characters.");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Course description is required.");

            RuleFor(c => c.IsActive)
                .NotNull().WithMessage("Course status is required.");

            RuleFor(c => c.CategorieId)
                .GreaterThan(0).WithMessage("Category ID must be greater than 0.");
        }
    }
}
