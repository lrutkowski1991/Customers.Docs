using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.DeleteServicePerformed
{
    public class DeleteServicePerformedCommand : IRequest
    {
        public Guid ServicePerformedId { get; set; }
    }
}
