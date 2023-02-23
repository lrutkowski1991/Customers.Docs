namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentDetail
{
    public class CustomerDto
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}
