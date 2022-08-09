using HRMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Domain.Interfaces.Repositories
{
    public interface IContractRepository
    {
        Task<IEnumerable<Contract>> GetContracts();
        Task<Contract> GetById(int id);
        Task<Contract> Create(Contract contract);
        Task<Contract> Update(Contract contract);
        Task<Contract> Remove(Contract contract);
    }
}
