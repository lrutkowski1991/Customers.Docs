using AutoMapper;
using Customers.Docs.Application.Features.Customers.Queries.GetCustomersList;
using Customers.Docs.Application.Features.Documents.Queries.GetDocumentDetail;
using Customers.Docs.Application.Features.Documents.Queries.GetDocumentsList;
using Customers.Docs.Application.Features.Registers.Queries.GetRegistersList;
using Customers.Docs.Application.Features.ServicesPerformed.Queries.GetServicesPerformedList;
using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Customers
            /* GetCustomersList */
            CreateMap<Customer, CustomerListVM>().ReverseMap();
            #endregion

            #region ServicesPerformed
            /* GetServicesPerformedList */
            CreateMap<ServicePerformed, GetServicePerformedListVM>().ReverseMap();
            #endregion

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
