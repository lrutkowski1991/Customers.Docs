using MediatR;

namespace Customers.Docs.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<Guid>
    {
        public string Name { get; set; } = String.Empty;
    }
}
