namespace Customers.Docs.Domain.Entities
{
    public class ServicePerformed
    {
        public Guid ServicePerformedId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}