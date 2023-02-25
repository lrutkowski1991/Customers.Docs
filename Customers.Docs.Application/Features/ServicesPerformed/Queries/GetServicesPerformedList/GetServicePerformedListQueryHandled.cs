using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Queries.GetServicesPerformedList
{
    public class GetServicePerformedListQueryHandled : IRequestHandler<GetServicePerformedListQuery, List<GetServicePerformedListVM>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ServicePerformed> _servicePerformedRepository;

        public GetServicePerformedListQueryHandled(IMapper mapper,
            IAsyncRepository<ServicePerformed> servicePerformedRepository)
        {
            _mapper = mapper;
            _servicePerformedRepository = servicePerformedRepository;
        }

        public async Task<List<GetServicePerformedListVM>> Handle(GetServicePerformedListQuery request, CancellationToken cancellationToken)
        {
            var servicesPerformed = (await _servicePerformedRepository.GetAllAsync()).ToList();
            return _mapper.Map<List<GetServicePerformedListVM>>(servicesPerformed);
        }
    }
}
