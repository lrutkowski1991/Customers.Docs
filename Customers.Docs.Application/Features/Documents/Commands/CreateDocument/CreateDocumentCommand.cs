using MediatR;

namespace Customers.Docs.Application.Features.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommand : IRequest<Guid>
    {
        public string Number { get; set; } = String.Empty;
        public DateTime DateOfIssue { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ServicePerformedId { get; set; }
        public Guid RegisterId { get; set; }
    }
}
