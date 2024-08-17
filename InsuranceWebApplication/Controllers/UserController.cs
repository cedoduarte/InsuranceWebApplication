using InsuranceWebApplication.CQRS.Users.Command.AuthenticateUser;
using InsuranceWebApplication.CQRS.Users.Command.CreateUser;
using InsuranceWebApplication.CQRS.Users.Command.UpdateUser;
using InsuranceWebApplication.CQRS.Users.Query.GetUserList;
using InsuranceWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserExcelFileService _userExcelFileService;

        public UserController(IUserService userService, IUserExcelFileService userExcelFileService)
        {
            _userService = userService;
            _userExcelFileService = userExcelFileService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            try
            {
                return Ok(await _userService.CreateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                return Ok(await _userService.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            try
            {
                return Ok(await _userService.UpdateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                return Ok(await _userService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetUserList([FromQuery] GetUserListQuery query)
        {
            try
            {
                return Ok(await _userService.GetListAsync(query));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("excel")]
        public async Task<IActionResult> GetUserExcelFile([FromQuery] GetUserListQuery query)
        {
            try
            {
                var file = await _userExcelFileService.GetFileAsync(query);
                return File(file.Bytes!, file.AcceptHeader!, file.FileName);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticateUserCommand command)
        {
            try
            {
                return Ok(await _userService.AuthenticateAsync(command));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
