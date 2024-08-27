namespace Suzane.WebApp.Models

{
    public class SearchPageViewModel
    {

        // Property for søkeparameteren
        public string Query { get; set; }

        // Property for søkeresultatene
        public string[] Results { get; set; }
    }
}
