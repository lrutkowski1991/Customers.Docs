using MediatR;

namespace Customers.Docs.Application.Contracts.Features.Documents
{
    public class GetDocumentListQuery : IRequest<List<DocumentListVM>>
    {
    }
}
