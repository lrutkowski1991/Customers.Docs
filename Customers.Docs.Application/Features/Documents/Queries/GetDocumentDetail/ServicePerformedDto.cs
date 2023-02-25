namespace Customers.Docs.Application.Features.Documents.Queries.GetDocumentDetail
{
    public class ServicePerformedDto
    {
        public Guid ServicePerformedId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}
