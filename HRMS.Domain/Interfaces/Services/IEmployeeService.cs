using HRMS.Domain.DTOs;
using HRMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
