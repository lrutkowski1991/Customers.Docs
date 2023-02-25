using MediatR;

namespace Customers.Docs.Application.Features.Registers.Queries.GetRegistersList
{
    public class GetRegisterListQuery : IRequest<List<RegisterListVM>>
    {
        public bool includeClosed { get; set; }
    }
}
