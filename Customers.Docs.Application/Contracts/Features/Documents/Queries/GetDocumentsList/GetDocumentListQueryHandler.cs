using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentsList
{
    public class GetDocumentListQueryHandler : IRequestHandler<GetDocumentListQuery, List<DocumentListVM>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Document> _documentRepository;
        public GetDocumentListQueryHandler(IMapper mapper, IAsyncRepository<Document> documentRepository)
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
        }

        public async Task<List<DocumentListVM>> Handle(GetDocumentListQuery request, CancellationToken cancellationToken)
        {
            var allDocuments = (await _documentRepository.GetAllAsync()).ToList();
            return _mapper.Map<List<DocumentListVM>>(allDocuments);
        }

    }
}
