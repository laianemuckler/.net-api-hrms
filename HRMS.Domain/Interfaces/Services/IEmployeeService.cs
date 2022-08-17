using HRMS.Domain.DTOs;

namespace HRMS.Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetEmployees();
        Task<EmployeeDTO> GetById(int id);
        Task<EmployeeDTO> GetEmployeeContract(int id);
        Task Add(EmployeeDTO employeeDTO);
        Task Update(EmployeeDTO employeeDTO);
        Task Remove(int id);
    }
}
