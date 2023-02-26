using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed
{
    public class CreateServicePerformedCommandHandler : IRequestHandler<CreateServicePerformedCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IServicePerformedRepository _servicePerformedRepository;
        public CreateServicePerformedCommandHandler(IMapper mapper,
            IServicePerformedRepository servicePerformedRepository)
        {
            _mapper = mapper;
            _servicePerformedRepository = servicePerformedRepository;
        }
        public async Task<Guid> Handle(CreateServicePerformedCommand request, CancellationToken cancellationToken)
        {
            var @servicePerformed = _mapper.Map<ServicePerformed>(request);
            @servicePerformed = await _servicePerformedRepository.AddAsync(@servicePerformed);
            return @servicePerformed.ServicePerformedId;
        }
    }
}
