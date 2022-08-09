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
        Task<IEnumerable<Contract>> GetContracts();
        Task<Contract> GetById(int id);
        Task Add(Contract contract);
        Task Update(Contract contract);
        Task Remove(int id);
    }
}
