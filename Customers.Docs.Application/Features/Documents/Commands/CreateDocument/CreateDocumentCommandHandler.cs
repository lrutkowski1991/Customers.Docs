using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IDocumentRepository _documentRepository;
        public CreateDocumentCommandHandler(IMapper mapper,
            IDocumentRepository documentRepository)
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
        }
        public async Task<Guid> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var @ducument = _mapper.Map<Document>(request);
            @ducument = await _documentRepository.AddAsync(@ducument);
            return @ducument.DocumentId;
        }
    }
}
