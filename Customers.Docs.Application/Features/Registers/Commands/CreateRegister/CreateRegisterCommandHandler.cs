using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.CreateRegister
{
    public class CreateRegisterCommandHandler : IRequestHandler<CreateRegisterCommand, CreateRegisterCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRegisterRepository _registerRepository;
        public CreateRegisterCommandHandler(IMapper mapper,
            IRegisterRepository registerRepository)
        {
            _mapper = mapper;
            _registerRepository = registerRepository;
        }

        public async Task<CreateRegisterCommandResponse> Handle(CreateRegisterCommand request, CancellationToken cancellationToken)
        {
            var createRegisterCommandResponse = new CreateRegisterCommandResponse();
            var validator = new CreateRegisterCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                createRegisterCommandResponse.Success = false;
                createRegisterCommandResponse.Errors = new List<string>();
                validationResult.Errors.ForEach(error => createRegisterCommandResponse.Errors.Add(error.ErrorMessage));
            }

            if (createRegisterCommandResponse.Success)
            {
                var register = new Register() 
                { 
                    Name = request.Name, 
                    StartDate = request.StartDate, 
                    EndDate = request.EndDate, 
                    IsClosed = request.IsClosed 
                };
                register = await _registerRepository.AddAsync(register);
                createRegisterCommandResponse.RegisterDto = _mapper.Map<CreateRegisterDto>(register);
            }

            return createRegisterCommandResponse;
        }
    }
}