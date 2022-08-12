using HRMS.Domain.DTOs;
using HRMS.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetAll()
        {
            var employees = await _employeeService.GetEmployees();
            if(employees == null)
                return NotFound("Employees not found");

            return Ok(employees);
        }

        [HttpGet("{id}", Name="GetEmployee")]
        public async Task<ActionResult<EmployeeDTO>> Get(int id)
        {
            var employee = await _employeeService.GetById(id);
            if (employee == null)
                return NotFound("Employee not found");
            
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDTO>> Post([FromBody] EmployeeDTO employeeDTO)
        {
            if (employeeDTO == null)
                return BadRequest("Data invalid.");
            //var employee = await _employeeService.GetById(employeeDTO.Id);
            await _employeeService.Add(employeeDTO);
            return new CreatedAtRouteResult("GetEmployee", 
                new { id = employeeDTO.Id}, employeeDTO );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeeDTO employeeDTO)
        {
            if (id != employeeDTO.Id)
                return BadRequest("Data Invalid");

            if (employeeDTO == null)
                return BadRequest("Data Invalid");
            await _employeeService.Update(employeeDTO);
            
            return Ok(employeeDTO);
        }

    }
}
