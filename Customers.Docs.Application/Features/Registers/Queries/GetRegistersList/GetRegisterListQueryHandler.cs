using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using MediatR;

namespace Customers.Docs.Application.Features.Registers.Queries.GetRegistersList
{
    public class GetRegisterListQueryHandler : IRequestHandler<GetRegisterListQuery, List<RegisterListVM>>
    {
        public readonly IMapper _mapper;
        public readonly IRegisterRepository _registerRepository;

        public GetRegisterListQueryHandler(IMapper mapper,
            IRegisterRepository registerRepository)
        {
            _mapper = mapper;
            _registerRepository = registerRepository;
        }

        public async Task<List<RegisterListVM>> Handle(GetRegisterListQuery request, CancellationToken cancellationToken)
        {
            var registers = await _registerRepository.GetAllAsync(request.includeClosed);
            return _mapper.Map<List<RegisterListVM>>(registers);
        }
    }
}
