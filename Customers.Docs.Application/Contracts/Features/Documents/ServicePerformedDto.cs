using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Docs.Application.Contracts.Features.Documents
{
    public class ServicePerformedDto
    {
        public Guid ServicePerformedId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}
