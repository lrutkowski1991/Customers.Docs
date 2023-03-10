namespace Customers.Docs.Domain.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}