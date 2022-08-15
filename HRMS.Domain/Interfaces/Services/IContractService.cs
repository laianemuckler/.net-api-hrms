using HRMS.Domain.DTOs;

namespace HRMS.Domain.Interfaces.Services
{
    public interface IContractService
    {
        Task<IEnumerable<ContractDTO>> GetContracts();
        Task<ContractDTO> GetById(int id);
        Task Add(ContractDTO contractDTO);
        Task<bool> Update(ContractDTO contractDTO);
        Task<bool> Remove(int id);
    }
}
