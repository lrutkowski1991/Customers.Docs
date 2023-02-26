using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.UpdateServicePerformed
{
    public class UpdateServicePerformedCommandHandler : IRequestHandler<UpdateServicePerformedCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ServicePerformed> _servicePerformedRepository;
        public UpdateServicePerformedCommandHandler(IMapper mapper,
            IAsyncRepository<ServicePerformed> servicePerformedRepository)
        {
            _mapper = mapper;
            _servicePerformedRepository = servicePerformedRepository;
        }
        public async Task<Unit> Handle(UpdateServicePerformedCommand request, CancellationToken cancellationToken)
        {
            var servicePerformed = await _servicePerformedRepository.GetByIdAsync(request.ServicePerformedId);
            _mapper.Map(request, servicePerformed, typeof(UpdateServicePerformedCommand), typeof(ServicePerformed));
            await _servicePerformedRepository.UpdateAsync(servicePerformed);
            return Unit.Value;
        }
    }
}
