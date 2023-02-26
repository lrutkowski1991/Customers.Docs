using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.UpdateRegister
{
    public class UpdateRegisterCommand : IRequest
    {
        public Guid RegisterId { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
    }
}
