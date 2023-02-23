using MediatR;

namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentsList
{
    public class GetDocumentListQuery : IRequest<List<DocumentListVM>>
    {
    }
}
