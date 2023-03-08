using Customers.Docs.Application.Responses;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed
{
    public class CreateServicePerformedCommandResponse : BaseResponse
    {
        public CreateServicePerformedCommandResponse() : base()
        {
        }
        public CreateServicePerformedDto ServicePerformedDto { get; set; } = default!;
    }
}
