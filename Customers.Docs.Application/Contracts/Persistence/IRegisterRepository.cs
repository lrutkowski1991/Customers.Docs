using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Contracts.Persistence
{
    public interface IRegisterRepository : IAsyncRepository<Document>
    {
        Task<List<Register>>  GetAllAsync(bool includeClosed);
    }
}
