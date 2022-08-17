using HRMS.Domain.Entities;
using HRMS.Domain.Interfaces.Repositories;
using HRMS.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _employeeContext;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _employeeContext = context;
        }
        public async Task<Employee> CreateAsync(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            await _employeeContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> GetByIdAsync(int Id)
        {
            return await _employeeContext.Employees.Include(c => c.Contract)
                .SingleOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<Employee> GetEmployeeContractAsync(int id)
        {
            // eager loading
            return await _employeeContext.Employees.Include(c => c.Contract)
                .SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _employeeContext.Employees.ToListAsync();
        }

        public async Task<Employee> RemoveAsync(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            await _employeeContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
            _employeeContext.Employees.Update(employee);
            await _employeeContext.SaveChangesAsync();
            return employee;
        }
    }
}
