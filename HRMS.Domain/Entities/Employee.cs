using HRMS.Domain.Validation;
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

        public Employee(string name, string email, string address, decimal payment)
        {
            ValidateDomain(name, email, address, payment);
        }

        public Employee(int id, string name, string email, string address, decimal payment)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name, email, address, payment);
        }

        public void Update(string name, string email, string address, decimal payment)
        {
            ValidateDomain(name, email, address, payment);

        }

        private void ValidateDomain(string name, string email, string address, decimal payment)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, minimum 3 characters.");
            DomainExceptionValidation.When(payment < 0, "Invalid payment value");

            Name = name;
            Email = email;
            Address = address;
            Payment = payment;
        }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
