using HRMS.Domain.DTOs;

namespace HRMS.Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetEmployees();
        Task<EmployeeDTO> GetById(int id);
        Task<EmployeeDTO> GetEmployeeContract(int id);
        Task Add(EmployeeDTO employeeDTO);
        Task<bool> Update(EmployeeDTO employeeDTO);
        Task<bool> Remove(int id);
    }
}
