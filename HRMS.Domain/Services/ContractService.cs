using AutoMapper;
using HRMS.Domain.DTOs;
using HRMS.Domain.Entities;
using HRMS.Domain.Interfaces.Repositories;
using HRMS.Domain.Interfaces.Services;

namespace HRMS.Domain.Services
{
    public class ContractService : IContractService
    {
        private IContractRepository _contractRepository;
        private readonly IMapper _mapper;


        public ContractService(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ContractDTO>> GetContracts()
        {
            var contractsEntity = await _contractRepository.GetContracts();
            return _mapper.Map<IEnumerable<ContractDTO>>(contractsEntity);
        }

        public async Task<ContractDTO> GetById(int id)
        {
            var contractEntity = await _contractRepository.GetById(id);
            return _mapper.Map<ContractDTO>(contractEntity);
        }

        public async Task Add(ContractDTO contractDTO)
        {
            // converter o DTO antes - lógica inversa
            var contractEntity = _mapper.Map<Contract>(contractDTO);
            await _contractRepository.Create(contractEntity);
        }

        public async Task Update(ContractDTO contractDTO)
        {
            var contractEntity = _mapper.Map<Contract>(contractDTO);
            await _contractRepository.Update(contractEntity);
           
        }

        public async Task Remove(int id)
        {
            var contractEntity = _contractRepository.GetById(id).Result;
            await _contractRepository.Remove(contractEntity);
        }
    }
}
