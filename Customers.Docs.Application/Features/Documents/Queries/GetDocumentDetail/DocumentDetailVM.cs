namespace Customers.Docs.Application.Features.Documents.Queries.GetDocumentDetail
{
    public class DocumentDetailVM
    {
        public Guid DocumentId { get; set; }
        public string Number { get; set; } = String.Empty;
        public DateTime DateOfIssue { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public Guid ServicePerformedId { get; set; }
        public ServicePerformedDto ServicePerformed { get; set; }
        public Guid RegisterId { get; set; }
        public RegisterDto Register { get; set; }
    }
}
