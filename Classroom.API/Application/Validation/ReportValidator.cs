using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class ReportValidator : AbstractValidator<Report>
    {
        public ReportValidator()
        {
            RuleFor(r => r.Content)
                .NotEmpty().WithMessage("Report content is required.");

            RuleFor(r => r.QuizId)
                .GreaterThan(0).WithMessage("Quiz ID must be greater than 0.");

            RuleFor(r => r.UserId)
                .GreaterThan(0).WithMessage("User ID must be greater than 0.");
        }
    }
}
