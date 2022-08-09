using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Domain.Entities
{
    public class Employee : EntityBase
    {
        public string? Name { get; private set; }
        public string? Email { get; private set; }
        public string? Address { get; private set; }
        public decimal Payment { get; private set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
