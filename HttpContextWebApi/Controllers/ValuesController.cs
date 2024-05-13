using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpContextWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public sealed class ValuesController : ControllerBase
    {
        [HttpGet("{age}/{name}")]
        public async Task<IActionResult> Get(int age, string name)
        {
            var httpcontext = HttpContext;
            httpcontext.Response.StatusCode = 201;
            await httpcontext.Response.WriteAsync("api is working");
            await httpcontext.Response.CompleteAsync();
            return NoContent(); // herhangi bir cevap dönmüyor
        }
        [HttpPost]
        public IActionResult Create()
        {
            var httpcontext = HttpContext;
            return Created();
        }
        public record UserDtpo(string Email,string Password)
        {
            

        }
    }
}
