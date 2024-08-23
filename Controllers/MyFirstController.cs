using Microsoft.AspNetCore.Mvc;

namespace Suzane.WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyFirstController : ControllerBase
    {
        [HttpGet]
        public string Index([FromQuery] string name)
        {
         
            return $"Hello {name} ";
        }
    }
}
