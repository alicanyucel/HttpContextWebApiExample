using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpContextWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public sealed class ValuesController : ControllerBase
    {
        [HttpGet] 
        public IActionResult Get(int age,string name)
        {
            var httpcontext = HttpContext;
            return NoContent(); // herhangi bir cevap dönmüyor
        }
    }
}
