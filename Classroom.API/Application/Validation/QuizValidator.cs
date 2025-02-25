using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class QuizValidator : AbstractValidator<Quiz>
    {
        public QuizValidator()
        {
            RuleFor(q => q.Title)
                .NotEmpty().WithMessage("Quiz title is required.")
                .MaximumLength(200).WithMessage("Title must not exceed 200 characters.");

            RuleFor(q => q.TotalScore)
                .GreaterThan(0).WithMessage("Total score must be greater than 0.");

            RuleFor(q => q.StartDate)
                .LessThan(q => q.EndDate).WithMessage("Start date must be before the end date.");

            RuleFor(q => q.Time)
                .GreaterThan(TimeSpan.Zero).WithMessage("Quiz duration must be greater than zero.");
        }
    }
}
