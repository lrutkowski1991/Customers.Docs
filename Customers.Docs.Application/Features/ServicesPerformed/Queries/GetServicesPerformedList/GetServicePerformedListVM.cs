namespace Customers.Docs.Application.Features.ServicesPerformed.Queries.GetServicesPerformedList
{
    public class GetServicePerformedListVM
    {
        public Guid ServicePerformedId { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Value { get; set; }
    }
}
