using Microsoft.AspNetCore.Mvc;
using Suzane.WebApp.Models;
using Suzane.WebApp.Services;


namespace Suzane.WebApp.Controllers
{
    public class SearchPageController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchPageController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("SearchPage")]
        public IActionResult Index(string q)
        {
            var model = new SearchPageViewModel
            {
                Query = q,
                Results = !string.IsNullOrWhiteSpace(q) ? _searchService.Search(q) : new string[] { }
            };

            return View(model);
        }
    }
}
