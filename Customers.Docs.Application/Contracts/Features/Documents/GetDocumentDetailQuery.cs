using MediatR;

namespace Customers.Docs.Application.Contracts.Features.Documents
{
    public class GetDocumentDetailQuery : IRequest<DocumentDetailVM>
    {
        public Guid Id { get; set; }
    }
}
