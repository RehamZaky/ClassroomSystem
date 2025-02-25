using Classroom.API.Domain.Entities;
using FluentValidation;

namespace Classroom.API.Application.Validation
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.UserId)
                .GreaterThan(0).WithMessage("User ID must be greater than 0.");

            RuleFor(p => p.ClassroomId)
                .GreaterThan(0).WithMessage("Classroom ID must be greater than 0.");

            RuleFor(p => p.Total)
                .GreaterThan(0).WithMessage("Total amount must be greater than 0.");

            RuleFor(p => p.Status)
                .NotEmpty().WithMessage("Payment status is required.")
                .Must(status => new[] { "Pending", "Completed", "Failed" }.Contains(status))
                .WithMessage("Invalid payment status. Allowed values: Pending, Completed, Failed.");
        }
    }
}
