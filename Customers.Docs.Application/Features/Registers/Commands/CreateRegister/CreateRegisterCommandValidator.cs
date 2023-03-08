using FluentValidation;

namespace Customers.Docs.Application.Features.Registers.Commands.CreateRegister
{
    public class CreateRegisterCommandValidator : AbstractValidator<CreateRegisterCommand>
    {
        public CreateRegisterCommandValidator()
        {
            RuleFor(rf => rf.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(80);

            RuleFor(rf => rf.StartDate)
                .NotEmpty()
                .NotNull();
            
            RuleFor(rf => rf.EndDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(gtoe => gtoe.StartDate);

            RuleFor(rf => rf.IsClosed)
                .NotEmpty()
                .NotNull();
        }
    }
}
