namespace Suzane.WebApp.Services
{
    public class SearchService : ISearchService
    {
        public string[] Search(string query)
        {
            // Implementer søkelogikken her
            // For eksempel, returner noen dummy data for nå
            return new string[] { "Result 1", "Result 2", "Result 3" };
        }
    }
}
