using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommandHandler : IRequestHandler<UpdateDocumentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Document> _documentRepository;
        public UpdateDocumentCommandHandler(IMapper mapper,
            IAsyncRepository<Document> documentRepository)
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
        }
        public async Task<Unit> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = await _documentRepository.GetByIdAsync(request.DocumentId);
            _mapper.Map(request, document, typeof(UpdateDocumentCommand), typeof(Document));
            await _documentRepository.UpdateAsync(document);
            return Unit.Value;
        }
    }
}
