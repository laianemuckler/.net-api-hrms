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
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        public async Task Add(Employee employee)
        {
            //return await _employeeRepository.CreateAsync(employee);
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
