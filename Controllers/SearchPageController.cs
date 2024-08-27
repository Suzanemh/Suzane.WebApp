using Microsoft.AspNetCore.Mvc;
using Suzane.WebApp.Models;
using Suzane.WebApp.Services;


namespace Suzane.WebApp.Controllers
{
    public class SearchPageController : Controller
    {

        //inisijerer ISearchService
        private readonly ISearchService _searchService;

        // Index-metoden tar inn en string q som parameter
        public IActionResult Index(string q)
        {
            // Opprett en instans av SearchPageViewModel
            var model = new SearchPageViewModel
            {
                // Sett Query-propertyen fra parameteren q
                Query = q,

            };

            // Gjør et søk kun om q ikke er string.IsNullOrWhiteSpace
            if (!string.IsNullOrWhiteSpace(q))
            {
                model.Results = _searchService.Search(q);
            }
            else
            {
                model.Results = new string[] { };
            }

            // Returner modellen i View-metoden
            return View(model);
        }
    }
}

