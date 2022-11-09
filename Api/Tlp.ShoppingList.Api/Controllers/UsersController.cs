using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
