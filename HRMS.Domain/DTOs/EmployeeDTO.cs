using HRMS.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Domain.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage="The Name is Required")]
        [MinLength(3)]
        [MaxLength(200)]
        [DisplayName("Name")]
        public string? Name { get; private set; }

        [Required(ErrorMessage = "The Email is Required")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Email")]
        public string? Email { get; private set; }

        [Required(ErrorMessage = "The Address is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Address")]
        public string? Address { get; private set; }

        [Required(ErrorMessage = "The Payment is Required")]
        [Column(TypeName="decimal(18,2")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Payment")]
        public decimal Payment { get; private set; }

        public Contract Contract { get; set; }

        [DisplayName("Contracts")]
        public int ContractId { get; set; }
      
    }
}
