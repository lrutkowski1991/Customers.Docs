using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Customers.Queries.GetCustomersList
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, List<CustomerListVM>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Customer> _customerRepository;

        public GetCustomerListQueryHandler(IMapper mapper, IAsyncRepository<Customer> customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<List<CustomerListVM>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var customers = (await _customerRepository.GetAllAsync()).ToList();
            return _mapper.Map<List<CustomerListVM>>(customers);
        }
    }
}
