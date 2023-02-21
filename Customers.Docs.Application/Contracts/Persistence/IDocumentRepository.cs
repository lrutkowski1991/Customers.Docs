using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Contracts.Persistence
{
    public interface IDocumentRepository : IAsyncRepository<Document>
    {
    }
}
