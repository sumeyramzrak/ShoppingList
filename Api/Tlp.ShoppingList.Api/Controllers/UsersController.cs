using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Services.Abstracts;

namespace Tlp.ShoppingList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService service;

        public UsersController(IUserService service)
        {
            this.service = service;
        }

        [HttpGet("list")]

        public async Task<IActionResult> GetUsers(CancellationToken cancellationToken)
        {
            var result = await service.GetUsers(cancellationToken);
            return Ok(result);
        }

        [HttpPost("add")]

        public async Task<IActionResult> AddUsers(NewUserRequestDto data,CancellationToken cancellationToken)
        {
            var result = await service.AddUser(data,cancellationToken);
            return Ok(result);
        }
    }
}
