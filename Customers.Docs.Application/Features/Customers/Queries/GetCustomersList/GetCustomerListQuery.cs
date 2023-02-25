using MediatR;

namespace Customers.Docs.Application.Features.Customers.Queries.GetCustomersList
{
    public class GetCustomerListQuery : IRequest<List<CustomerListVM>>
    {
    }
}
