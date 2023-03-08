using Customers.Docs.Application.Responses;

namespace Customers.Docs.Application.Features.Registers.Commands.CreateRegister
{
    public class CreateRegisterCommandResponse : BaseResponse
    {
        public CreateRegisterCommandResponse() : base()
        {
        }
        public CreateRegisterDto RegisterDto { get; set; } = default!;
    }
}
