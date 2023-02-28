using Customers.Docs.Application.Responses;

namespace Customers.Docs.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandResponse : BaseResponse
    {
        public CreateCustomerCommandResponse() : base()
        {
        }
        public CreateCustomerDto CustomerDto { get; set; } = default!;
    }
}
