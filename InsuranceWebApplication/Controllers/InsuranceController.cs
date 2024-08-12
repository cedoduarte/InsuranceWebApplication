using InsuranceWebApplication.CQRS.Insurances.Command.CreateInsurance;
using InsuranceWebApplication.CQRS.Insurances.Command.UpdateInsurance;
using InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList;
using InsuranceWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsuranceController : Controller
    {
        private readonly IInsuranceService _insuranceService;

        public InsuranceController(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateInsurance(CreateInsuranceCommand command)
        {
            try
            {
                return Ok(await _insuranceService.CreateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsurance(int id)
        {
            try
            {
                return Ok(await _insuranceService.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateInsurance(UpdateInsuranceCommand command)
        {
            try
            {
                return Ok(await _insuranceService.UpdateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInsuranceById(int id)
        {
            try
            {
                return Ok(await _insuranceService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetInsuranceList([FromQuery] GetInsuranceListQuery query)
        {
            try
            {
                return Ok(await _insuranceService.GetListAsync(query));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
