using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Queries.GetServicesPerformedList
{
    public class GetServicePerformedListQuery : IRequest<List<GetServicePerformedListVM>>
    {
    }
}
