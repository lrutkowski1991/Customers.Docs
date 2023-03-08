using FluentValidation;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed
{
    public class CreateServicePerformedCommandValidator : AbstractValidator<CreateServicePerformedCommand>
    {
        public CreateServicePerformedCommandValidator()
        {
            RuleFor(rf => rf.Name)
               .NotEmpty()
               .NotNull()
               .MaximumLength(80);

            RuleFor(rf => rf.Value)
               .NotEmpty()
               .NotNull();
        }
    }
}
