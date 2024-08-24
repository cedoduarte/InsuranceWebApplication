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
        private readonly IInsuranceExcelFileService _insuranceExcelFileService;

        public InsuranceController(IInsuranceService insuranceService, IInsuranceExcelFileService insuranceExcelFileService)
        {
            _insuranceService = insuranceService;
            _insuranceExcelFileService = insuranceExcelFileService;
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
                var insurances = await _insuranceService.GetListAsync(query);
                if (insurances.TotalCount > 0)
                {
                    return Ok(insurances);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("excel")]
        public async Task<IActionResult> GetInsuranceExcelFile([FromQuery] GetInsuranceListQuery query)
        {
            try
            {
                var file = await _insuranceExcelFileService.GetFileAsync(query);
                return File(file.Bytes!, file.AcceptHeader!, file.FileName);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
