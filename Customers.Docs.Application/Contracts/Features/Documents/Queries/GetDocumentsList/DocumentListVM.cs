namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentsList
{
    public class DocumentListVM
    {
        public Guid DocumentId { get; set; }
        public string Number { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
