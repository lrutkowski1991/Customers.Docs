using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.UpdateRegister
{
    public class UpdateRegisterCommandHandler : IRequestHandler<UpdateRegisterCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Register> _registerRepository;
        public UpdateRegisterCommandHandler(IMapper mapper,
            IAsyncRepository<Register> registerRepository)
        {
            _mapper = mapper;
            _registerRepository = registerRepository;
        }
        public async Task<Unit> Handle(UpdateRegisterCommand request, CancellationToken cancellationToken)
        {
            var register = await _registerRepository.GetByIdAsync(request.RegisterId);
            _mapper.Map(request, register, typeof(UpdateRegisterCommand), typeof(Register));
            await _registerRepository.UpdateAsync(register);
            return Unit.Value;
        }
    }
}
