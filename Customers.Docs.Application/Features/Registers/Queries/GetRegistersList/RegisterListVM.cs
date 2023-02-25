namespace Customers.Docs.Application.Features.Registers.Queries.GetRegistersList
{
    public class RegisterListVM
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
    }
}
