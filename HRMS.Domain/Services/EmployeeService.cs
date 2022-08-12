﻿using AutoMapper;
using HRMS.Domain.DTOs;
using HRMS.Domain.Entities;
using HRMS.Domain.Interfaces.Repositories;
using HRMS.Domain.Interfaces.Services;

namespace HRMS.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            var employeesEntity = await _employeeRepository.GetEmployeesAsync();
            return _mapper.Map<IEnumerable<EmployeeDTO>>(employeesEntity);
        }

        public async Task<EmployeeDTO> GetById(int id)
        {
            var employeeEntity = await _employeeRepository.GetByIdAsync(id);
            return _mapper.Map<EmployeeDTO>(employeeEntity);
        }

        public async Task<EmployeeDTO> GetEmployeeContract(int id)
        {
            var employeeEntity = await _employeeRepository.GetEmployeeContractAsync(id);
            return _mapper.Map<EmployeeDTO>(employeeEntity);
        }

        public async Task Add(EmployeeDTO employeeDTO)
        {
           var employeeEntity = _mapper.Map<Employee>(employeeDTO);
            await _employeeRepository.CreateAsync(employeeEntity);
        }

        public async Task<bool> Update(EmployeeDTO employeeDTO)
        {
            var employeeEntity = _mapper.Map<Employee>(employeeDTO);
            var employee = await _employeeRepository.UpdateAsync(employeeEntity);
            if (employeeEntity == null)
                throw new Exception("Employee not found");
            return true;
        }


        public async Task<bool> Remove(int id)
        {
            //var employeeEntity = _employeeRepository.GetByIdAsync(id).Result;
            //await _employeeRepository.RemoveAsync(employeeEntity);

            var employeeEntity = await _employeeRepository.GetByIdAsync(id);
            if (employeeEntity == null)
                throw new Exception("Employee not found");
            await _employeeRepository.RemoveAsync(employeeEntity);
            return true;
        }

    }
}
