namespace Customers.Docs.Domain.Entities
{
    public class Register
    {
        public Guid RegisterId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
