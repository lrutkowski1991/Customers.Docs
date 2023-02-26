using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.DeleteRegister
{
    public class DeleteRegisterCommand : IRequest
    {
        public Guid RegisterId { get; set; }
    }
}
