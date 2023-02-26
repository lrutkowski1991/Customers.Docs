using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.DeleteServicePerformed
{
    public class DeleteServicePerformedCommandHandler : IRequestHandler<DeleteServicePerformedCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ServicePerformed> _servicePerformedRepository;
        public DeleteServicePerformedCommandHandler(IMapper mapper,
            IAsyncRepository<ServicePerformed> servicePerformedRepository)
        {
            _mapper = mapper;
            _servicePerformedRepository = servicePerformedRepository;
        }
        public async Task<Unit> Handle(DeleteServicePerformedCommand request, CancellationToken cancellationToken)
        {
            var servicePerformed = await _servicePerformedRepository.GetByIdAsync(request.ServicePerformedId);
            await _servicePerformedRepository.DeleteAsync(servicePerformed);
            return Unit.Value;
        }
    }
}
