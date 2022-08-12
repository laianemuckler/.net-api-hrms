using HRMS.Domain.DTOs;
using HRMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
