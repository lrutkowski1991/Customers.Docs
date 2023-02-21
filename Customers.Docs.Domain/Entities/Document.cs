namespace Customers.Docs.Domain.Entities
{
    public class Document
    {
        public Guid DocumentId { get; set; }
        public string Number { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid ServicePerformedId { get; set; }
        public ServicePerformed ServicePerformed { get; set; }        
        public Guid RegisterId { get; set; }
        public Register Register { get; set; }
    }
}
