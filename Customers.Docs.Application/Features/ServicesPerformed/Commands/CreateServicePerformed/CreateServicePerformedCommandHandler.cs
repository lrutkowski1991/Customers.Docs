using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed
{
    public class CreateServicePerformedCommandHandler : IRequestHandler<CreateServicePerformedCommand, CreateServicePerformedCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IServicePerformedRepository _servicePerformedRepository;
        public CreateServicePerformedCommandHandler(IMapper mapper,
            IServicePerformedRepository servicePerformedRepository)
        {
            _mapper = mapper;
            _servicePerformedRepository = servicePerformedRepository;
        }

        public async Task<CreateServicePerformedCommandResponse> Handle(CreateServicePerformedCommand request, CancellationToken cancellationToken)
        {
            var createServicePerformedCommandResponse = new CreateServicePerformedCommandResponse();
            var validator = new CreateServicePerformedCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                createServicePerformedCommandResponse.Success = false;
                createServicePerformedCommandResponse.Errors = new List<string>();
                validationResult.Errors.ForEach(error => createServicePerformedCommandResponse.Errors.Add(error.ErrorMessage));
            }

            if (createServicePerformedCommandResponse.Success)
            {
                var servicePerformed = new ServicePerformed()
                {
                    Name = request.Name,
                    Value = request.Value
                };
                servicePerformed = await _servicePerformedRepository.AddAsync(servicePerformed);
                createServicePerformedCommandResponse.ServicePerformedDto = _mapper.Map<CreateServicePerformedDto>(servicePerformed);
            }

            return createServicePerformedCommandResponse;
        }
    }
}