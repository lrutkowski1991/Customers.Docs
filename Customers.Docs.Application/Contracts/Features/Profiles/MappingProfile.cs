using AutoMapper;
using Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentDetail;
using Customers.Docs.Application.Contracts.Features.Documents.Queries.GetDocumentsList;
using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Contracts.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Document, DocumentListVM>().ReverseMap();
            CreateMap<Document, DocumentDetailVM>().ReverseMap();
            CreateMap<Register, RegisterDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<ServicePerformed, ServicePerformedDto>();
        }
    }
}
