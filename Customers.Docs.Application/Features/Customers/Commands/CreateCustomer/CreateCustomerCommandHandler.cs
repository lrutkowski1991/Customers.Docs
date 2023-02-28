using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public CreateCustomerCommandHandler(IMapper mapper,
            ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var createCustomerCommandResponse = new CreateCustomerCommandResponse();

            var validator = new CreateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                createCustomerCommandResponse.Success = false;
                createCustomerCommandResponse.Errors = new List<string>();
                validationResult.Errors.ForEach(error => createCustomerCommandResponse.Errors.Add(error.ErrorMessage));
            }

            if (createCustomerCommandResponse.Success)
            {
                var customer = new Customer() { Name = request.Name };
                customer = await _customerRepository.AddAsync(customer);
                createCustomerCommandResponse.CustomerDto = _mapper.Map<CreateCustomerDto>(customer);
            }

            return createCustomerCommandResponse;
        }
    }
}
