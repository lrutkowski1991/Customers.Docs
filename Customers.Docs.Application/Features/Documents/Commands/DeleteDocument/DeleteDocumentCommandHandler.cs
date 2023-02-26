using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Documents.Commands.DeleteDocument
{
    public class DeleteDocumentCommandHandler : IRequestHandler<DeleteDocumentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Document> _documentRepository;
        public DeleteDocumentCommandHandler(IMapper mapper,
            IAsyncRepository<Document> documentRepository)
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
        }
        public async Task<Unit> Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = await _documentRepository.GetByIdAsync(request.DocumentId);
            await _documentRepository.DeleteAsync(document);
            return Unit.Value;
        }
    }
}
