using AutoMapper;
using Customers.Docs.Application.Features.Customers.Commands.CreateCustomer;
using Customers.Docs.Application.Features.Customers.Commands.DeleteCustomer;
using Customers.Docs.Application.Features.Customers.Commands.UpdateCustomer;
using Customers.Docs.Application.Features.Customers.Queries.GetCustomersList;
using Customers.Docs.Application.Features.Documents.Commands.CreateDocument;
using Customers.Docs.Application.Features.Documents.Commands.DeleteDocument;
using Customers.Docs.Application.Features.Documents.Commands.UpdateDocument;
using Customers.Docs.Application.Features.Documents.Queries.GetDocumentDetail;
using Customers.Docs.Application.Features.Documents.Queries.GetDocumentsList;
using Customers.Docs.Application.Features.Registers.Commands.CreateRegister;
using Customers.Docs.Application.Features.Registers.Commands.DeleteRegister;
using Customers.Docs.Application.Features.Registers.Commands.UpdateRegister;
using Customers.Docs.Application.Features.Registers.Queries.GetRegistersList;
using Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed;
using Customers.Docs.Application.Features.ServicesPerformed.Commands.DeleteServicePerformed;
using Customers.Docs.Application.Features.ServicesPerformed.Commands.UpdateServicePerformed;
using Customers.Docs.Application.Features.ServicesPerformed.Queries.GetServicesPerformedList;
using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Customers
            #region Queries
            CreateMap<Customer, CustomerListVM>().ReverseMap();
            #endregion
            #region Commands
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
            CreateMap<Customer, DeleteCustomerCommand>().ReverseMap();
            #endregion
            #endregion

            #region ServicesPerformed
            #region Queries
            CreateMap<ServicePerformed, GetServicePerformedListVM>().ReverseMap();
            #endregion
            #region Commands
            CreateMap<ServicePerformed, CreateServicePerformedCommand>().ReverseMap();
            CreateMap<ServicePerformed, UpdateServicePerformedCommand>().ReverseMap();
            CreateMap<ServicePerformed, DeleteServicePerformedCommand>().ReverseMap();
            #endregion
            #endregion

            #region Registers
            #region Queries
            CreateMap<Register, RegisterListVM>();
            #endregion
            #region Commands
            CreateMap<Register, CreateRegisterCommand>().ReverseMap();
            CreateMap<Register, UpdateRegisterCommand>().ReverseMap();
            CreateMap<Register, DeleteRegisterCommand>().ReverseMap();
            #endregion
            #endregion

            #region Documents
            #region Queries
            /* GetDocumentsList */
            CreateMap<Document, DocumentListVM>().ReverseMap();
            /* GetDocumentDetail */
            CreateMap<Document, DocumentDetailVM>().ReverseMap();
            CreateMap<Register, RegisterDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<ServicePerformed, ServicePerformedDto>();
            #endregion
            #region Commands
            CreateMap<Document, CreateDocumentCommand>().ReverseMap();
            CreateMap<Document, UpdateDocumentCommand>().ReverseMap();
            CreateMap<Document, DeleteDocumentCommand>().ReverseMap();
            #endregion
            #endregion
        }
    }
}
