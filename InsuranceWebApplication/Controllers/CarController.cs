using InsuranceWebApplication.CQRS.Cars.Command.CreateCar;
using InsuranceWebApplication.CQRS.Cars.Command.UpdateCar;
using InsuranceWebApplication.CQRS.Cars.Query.GetCarList;
using InsuranceWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarExcelFileService _carExcelFileService;

        public CarController(ICarService carService, ICarExcelFileService carExcelFileService)
        {
            _carService = carService;
            _carExcelFileService = carExcelFileService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            try
            {
                return Ok(await _carService.CreateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            try
            {
                return Ok(await _carService.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            try
            {
                return Ok(await _carService.UpdateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            try
            {
                return Ok(await _carService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetCarList([FromQuery] GetCarListQuery query)
        {
            try
            {
                var cars = await _carService.GetListAsync(query);
                if (cars.TotalCount > 0)
                {
                    return Ok(cars);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("excel")]
        public async Task<IActionResult> GetCarExcelFile([FromQuery] GetCarListQuery query)
        {
            try
            {
                var file = await _carExcelFileService.GetFileAsync(query);
                return File(file.Bytes!, file.AcceptHeader!, file.FileName);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
