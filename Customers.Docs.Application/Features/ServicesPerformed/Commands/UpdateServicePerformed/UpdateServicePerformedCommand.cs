using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.UpdateServicePerformed
{
    public class UpdateServicePerformedCommand : IRequest
    {
        public Guid ServicePerformedId { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Value { get; set; }
    }
}
