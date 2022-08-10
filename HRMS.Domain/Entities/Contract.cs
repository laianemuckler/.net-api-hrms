using HRMS.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Domain.Entities
{
    public class Contract : EntityBase
    {
        public string? Description { get; private set; }

        public Contract(string description)
        {
            ValidateDomain(description);
        }

        public Contract(int id, string description)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(description);
        }

        public void Update(string description)
        {
            ValidateDomain(description);
        }

        public List<Employee> Employees { get; set; }

        private void ValidateDomain(string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required.");
            DomainExceptionValidation.When(description.Length < 2, "Invalid description, minimum 3 characters.");

            Description = description;
        }
    }
}
