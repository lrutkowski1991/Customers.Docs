using MediatR;

namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentDetail
{
    public class GetDocumentDetailQuery : IRequest<DocumentDetailVM>
    {
        public Guid Id { get; set; }
    }
}
