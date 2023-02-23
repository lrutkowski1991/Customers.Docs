using AutoMapper;
using Customers.Docs.Application.Contracts.Persistence;
using Customers.Docs.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentDetail
{
    public class GetDocumentDetailQueryHandler : IRequestHandler<GetDocumentDetailQuery, DocumentDetailVM>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Document> _documentRepository;
        private readonly IAsyncRepository<Register> _registerRepository;
        private readonly IAsyncRepository<Customer> _customerRepository;
        private readonly IAsyncRepository<ServicePerformed> _servicePerformedRepository;

        public GetDocumentDetailQueryHandler(IMapper mapper,
               IAsyncRepository<Document> documentRepository,
               IAsyncRepository<Register> registerRepository,
               IAsyncRepository<Customer> customerRepository,
               IAsyncRepository<ServicePerformed> servicePerformedRepository)
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
            _registerRepository = registerRepository;
            _customerRepository = customerRepository;
            _servicePerformedRepository = servicePerformedRepository;
        }

        public async Task<DocumentDetailVM> Handle(GetDocumentDetailQuery request, CancellationToken cancellationToken)
        {
            var @document = await _documentRepository.GetByIdAsync(request.Id);
            var documentDetailDto = _mapper.Map<DocumentDetailVM>(@document);

            var @register = await _registerRepository.GetByIdAsync(@document.RegisterId);
            documentDetailDto.Register = _mapper.Map<RegisterDto>(@register);

            var @customer = await _customerRepository.GetByIdAsync(@document.CustomerId);
            documentDetailDto.Customer = _mapper.Map<CustomerDto>(@customer);

            var @servicePerformed = await _servicePerformedRepository.GetByIdAsync(@document.ServicePerformedId);
            documentDetailDto.ServicePerformed = _mapper.Map<ServicePerformedDto>(@servicePerformed);

            return documentDetailDto;
        }
    }
}
