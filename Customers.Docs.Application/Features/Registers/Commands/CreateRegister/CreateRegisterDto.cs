namespace Customers.Docs.Application.Features.Registers.Commands.CreateRegister
{
    public class CreateRegisterDto
    {
        public Guid RegisterId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
    }
}
