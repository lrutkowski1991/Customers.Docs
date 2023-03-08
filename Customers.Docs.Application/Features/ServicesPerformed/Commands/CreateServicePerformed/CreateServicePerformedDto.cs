namespace Customers.Docs.Application.Features.ServicesPerformed.Commands.CreateServicePerformed
{
    public class CreateServicePerformedDto
    {
        public Guid ServicePerformedId { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Value { get; set; }
    }
}
