using AutoMapper;
using Customers.Docs.Application.Features.Documents.Queries.GetDocumentDetail;
using Customers.Docs.Application.Features.Documents.Queries.GetDocumentsList;
using Customers.Docs.Application.Features.Registers.Queries.GetRegistersList;
using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Registers
            /* GetRegistersList */
            CreateMap<Register, RegisterListVM>();
            #endregion

            #region Documents
            /* GetDocumentsList */
            CreateMap<Document, DocumentListVM>().ReverseMap();
            /* GetDocumentDetail */
            CreateMap<Document, DocumentDetailVM>().ReverseMap();
            CreateMap<Register, RegisterDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<ServicePerformed, ServicePerformedDto>();
            #endregion
        }
    }
}
