namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentDetail
{
    public class RegisterDto
    {
        public Guid RegisterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsClosed { get; set; }
    }
}
