using HRMS.Domain.DTOs;

namespace HRMS.Domain.Interfaces.Services
{
    public interface IContractService
    {
        Task<IEnumerable<ContractDTO>> GetContracts();
        Task<ContractDTO> GetById(int id);
        Task Add(ContractDTO contractDTO);
        Task Update(ContractDTO contractDTO);
        Task Remove(int id);
    }
}
