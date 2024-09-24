using IT2.Invoice.Application.System.Users;
using IT2.Invoice.ViewModel.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT2.Invoice.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService) 
        { 
            _userService = userService;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid) 
            { 
                return BadRequest(ModelState);
            }
            var result = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(result.ResultObj)) 
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
