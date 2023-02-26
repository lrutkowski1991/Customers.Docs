using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.CreateRegister
{
    public class CreateRegisterCommand : IRequest<Guid>
    {
        public string Name { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
    }
}
