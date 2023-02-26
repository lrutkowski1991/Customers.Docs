using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Registers.Commands.DeleteRegister
{
    public class DeleteRegisterCommandHandler : IRequestHandler<DeleteRegisterCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Register> _registerRepository;
        public DeleteRegisterCommandHandler(IMapper mapper,
            IAsyncRepository<Register> registerRepository)
        {
            _mapper = mapper;
            _registerRepository = registerRepository;
        }
        public async Task<Unit> Handle(DeleteRegisterCommand request, CancellationToken cancellationToken)
        {
            var register = await _registerRepository.GetByIdAsync(request.RegisterId);
            await _registerRepository.DeleteAsync(register);
            return Unit.Value;
        }
    }
}
