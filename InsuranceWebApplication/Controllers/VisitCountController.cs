using InsuranceWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitCountController : Controller
    {
        private readonly IVisitCountService _visitCountService;

        public VisitCountController(IVisitCountService visitCountService)
        {
            _visitCountService = visitCountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCount()
        {
            return Ok(await _visitCountService.GetCountAsync());

        }

        [HttpPost]
        public async Task<IActionResult> IncrementCount()
        {
            int count = await _visitCountService.IncrementCountAsync();
            return Ok(count);
        }
    }
}
