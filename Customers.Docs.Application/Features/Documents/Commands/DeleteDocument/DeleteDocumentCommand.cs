using MediatR;

namespace Customers.Docs.Application.Features.Documents.Commands.DeleteDocument
{
    public class DeleteDocumentCommand : IRequest
    {
        public Guid DocumentId { get; set; }
    }
}
