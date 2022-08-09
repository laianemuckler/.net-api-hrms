using HRMS.Domain.Entities;
using HRMS.Domain.Interfaces.Repositories;
using HRMS.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Domain.Services
{
    public class ContractService : IContractService
    {
        private IContractRepository _contractRepository;
        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }
        public async Task Add(Contract contract)
        {

        }

        public async Task<Contract> GetById(int id)
        {
            return await _contractRepository.GetById(id);
        }

        public async Task<IEnumerable<Contract>> GetContracts()
        {
            return await _contractRepository.GetContracts();
        }

        public async Task Remove(int id)
        {
            
        }

        public async Task Update(Contract contract)
        {
           
        }
    }
}
