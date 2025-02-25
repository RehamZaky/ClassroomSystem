using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class DiscussionValidator : AbstractValidator<Discussion>
    {
        public DiscussionValidator()
        {
            RuleFor(d => d.Content)
                .NotEmpty().WithMessage("Discussion content is required.");

            RuleFor(d => d.CreatorId)
                .GreaterThan(0).WithMessage("Creator ID must be greater than 0.");

            RuleFor(d => d.ClassroomId)
                .GreaterThan(0).WithMessage("Classroom ID must be greater than 0.");
        }
    }
}
