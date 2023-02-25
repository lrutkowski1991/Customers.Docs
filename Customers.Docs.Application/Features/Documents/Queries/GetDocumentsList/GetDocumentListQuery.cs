using MediatR;

namespace Customers.Docs.Application.Features.Documents.Queries.GetDocumentsList
{
    public class GetDocumentListQuery : IRequest<List<DocumentListVM>>
    {
    }
}
