using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed
{
    public class CreateServicePerformedCommand : IRequest<Guid>
    {
        public string Name { get; set; } = String.Empty;
        public decimal Value { get; set; }
    }
}
