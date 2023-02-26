using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.CreateRegister
{
    public class CreateRegisterCommandHandler : IRequestHandler<CreateRegisterCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IRegisterRepository _registerRepository;
        public CreateRegisterCommandHandler(IMapper mapper,
            IRegisterRepository registerRepository)
        {
            _mapper = mapper;
            _registerRepository = registerRepository;
        }
        public async Task<Guid> Handle(CreateRegisterCommand request, CancellationToken cancellationToken)
        {
            var @register = _mapper.Map<Register>(request);
            @register = await _registerRepository.AddAsync(@register);
            return @register.RegisterId;
        }
    }
}
