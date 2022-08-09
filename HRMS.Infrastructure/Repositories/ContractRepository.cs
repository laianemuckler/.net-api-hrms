﻿using HRMS.Domain.Entities;
using HRMS.Domain.Interfaces.Repositories;
using HRMS.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Infrastructure.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationDbContext _contractContext;
        public ContractRepository(ApplicationDbContext context)
        {
            _contractContext = context;
        }
        public async Task<Contract> Create(Contract contract)
        {
            _contractContext.Add(contract);
            await _contractContext.SaveChangesAsync();
            return contract;
        }

        public async Task<Contract> GetById(int id)
        {
            return await _contractContext.Contracts.FindAsync(id);
        }

        public async Task<IEnumerable<Contract>> GetContracts()
        {
            return await _contractContext.Contracts.ToListAsync();
        }

        public async Task<Contract> Remove(Contract contract)
        {
            _contractContext.Remove(contract);
            await _contractContext.SaveChangesAsync();
            return contract;
        }

        public async Task<Contract> Update(Contract contract)
        {
            _contractContext.Update(contract);
            await _contractContext.SaveChangesAsync();
            return contract;
        }
    }
}