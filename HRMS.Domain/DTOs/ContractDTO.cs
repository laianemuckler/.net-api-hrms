using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Domain.DTOs
{
    public class ContractDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Description is Required.")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Description")]
        public string? Description { get; private set; }

    }
}
