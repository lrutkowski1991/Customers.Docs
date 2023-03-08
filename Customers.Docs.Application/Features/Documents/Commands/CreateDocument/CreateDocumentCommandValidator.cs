using FluentValidation;

namespace Customers.Docs.Application.Features.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandValidator : AbstractValidator<CreateDocumentCommand>
    {
        public CreateDocumentCommandValidator()
        {
            RuleFor(rf => rf.Number)
                .NotEmpty()
                .NotNull()
                .MaximumLength(12);

            RuleFor(rf => rf.DateOfIssue)
                .NotEmpty()
                .NotNull();

            RuleFor(rf => rf.RegisterId)
                .NotEmpty()
                .NotNull();

            RuleFor(rf => rf.CustomerId)
                .NotEmpty()
                .NotNull();

            RuleFor(rf => rf.ServicePerformedId)
                .NotEmpty()
                .NotNull();
        }
    }
}
