using Customers.Docs.Application.Responses;

namespace Customers.Docs.Application.Features.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandResponse : BaseResponse
    {
        public CreateDocumentCommandResponse() : base()
        {
        }
        public CreateDocumentDto DocumentDto { get; set; }
    }
}
