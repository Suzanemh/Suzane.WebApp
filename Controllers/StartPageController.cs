using Microsoft.AspNetCore.Mvc;

namespace Suzane.WebApp.Controllers
{

    [Route("")]
    public class StartPageController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
			ViewData["Title"] = "Home Page";
			return View();
		}
    }
}

