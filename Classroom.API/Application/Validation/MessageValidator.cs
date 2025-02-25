using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(m => m.Content)
                .NotEmpty().WithMessage("Message content is required.");

            RuleFor(m => m.SenderId)
                .GreaterThan(0).WithMessage("Sender ID must be greater than 0.");

            RuleFor(m => m.ReceiverId)
                .GreaterThan(0).WithMessage("Receiver ID must be greater than 0.");
        }
    }
}
