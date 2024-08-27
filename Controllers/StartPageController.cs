using Microsoft.AspNetCore.Mvc;
using Suzane.WebApp.Models;

namespace Suzane.WebApp.Controllers
{

    [Route("")]
    public class StartPageController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // Opprett en instans av StartPageViewModel
            var model = new StartPageViewModel
            {
                // Sett verdien for Body-propertyen
                Body = "hey suz"
              
            };

            
            // Returner modellen i View-metoden
            return View(model);
        }
    }
}

