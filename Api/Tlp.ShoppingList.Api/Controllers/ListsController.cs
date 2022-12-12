using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tlp.ShoppingList.Services.Abstracts;

namespace Tlp.ShoppingList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListsController : ControllerBase
    {
        private readonly IListService service;
    }
}
