using HRMS.Domain.DTOs;
using HRMS.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;
        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractDTO>>> GetAll()
        {
            var contracts = await _contractService.GetContracts();
            if (contracts == null)
            {
                return NotFound("Contracts not found.");
            }
            return Ok(contracts);
        }

        [HttpGet("{id:int}", Name ="GetContract")]
        public async Task<ActionResult<ContractDTO>> GetById(int id)
        {
            var contract = await _contractService.GetById(id);
            if (contract == null)
            {
                return NotFound("Contract not found.");
            }
            return Ok(contract);

        }

        // passo os dados do novo contrato no body da request

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ContractDTO contractDTO)
        {
            if (contractDTO == null)
            {
                return BadRequest("Invalid Data.");
            }
            await _contractService.Add(contractDTO);
            
            // 201 created
            return new CreatedAtRouteResult("GetContract", new { id = contractDTO.Id }, contractDTO);
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] ContractDTO contractDTO)
        {
            if (id != contractDTO.Id)
                return BadRequest();

            if (contractDTO == null)
                return BadRequest();
            await _contractService.Update(contractDTO);

            return Ok(contractDTO);
          
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ContractDTO>> Delete(int id)
        {
            var contract = await _contractService.GetById(id);
            if (contract == null)
                return NotFound("Contract not found.");

            await _contractService.Remove(id);
            return Ok(contract);

        }
    }
}
