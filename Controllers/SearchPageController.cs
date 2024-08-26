using Microsoft.AspNetCore.Mvc;

namespace Suzane.WebApp.Controllers
{
    public class SearchPageController : Controller
    {
        public IActionResult Index(string q)
        {


            //returnerer visningen med parameteren q    
            return View((object)q);
        }
    }
}
