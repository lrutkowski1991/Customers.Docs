using MediatR;

namespace Customers.Docs.Application.Features.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}
