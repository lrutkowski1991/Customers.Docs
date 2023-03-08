namespace Customers.Docs.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerDto
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}
