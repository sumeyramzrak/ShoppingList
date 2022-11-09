using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tlp.ShoppingList.Data.Request.Contracts;

namespace Tlp.ShoppingList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly Services.Abstracts.IAuthenticationService service;

        public AuthenticationController(Services.Abstracts.IAuthenticationService service)
        {
            this.service = service;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.LoginUser(data, cancellationToken);
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.RegisterUser(data, cancellationToken);
            return Ok(result);
        }
    }
}
