using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;

namespace Customers.Docs.Application.Features.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, CreateDocumentCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IDocumentRepository _documentRepository;
        public CreateDocumentCommandHandler(IMapper mapper,
            IDocumentRepository documentRepository)
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
        }

        public async Task<CreateDocumentCommandResponse> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var createDocumentCommandResponse = new CreateDocumentCommandResponse();
            var validator = new CreateDocumentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                createDocumentCommandResponse.Success = false;
                createDocumentCommandResponse.Errors = new List<string>();
                validationResult.Errors.ForEach(error => createDocumentCommandResponse.Errors.Add(error.ErrorMessage));
            }

            if (createDocumentCommandResponse.Success)
            {
                var document = new Document()
                {
                    Number = request.Number,
                    DateOfIssue = request.DateOfIssue,
                    RegisterId = request.RegisterId,
                    CustomerId = request.CustomerId,
                    ServicePerformedId = request.ServicePerformedId
                };
                document = await _documentRepository.AddAsync(document);
                createDocumentCommandResponse.DocumentDto = _mapper.Map<CreateDocumentDto>(document);
            }
            
            return createDocumentCommandResponse;
        }
    }
}
