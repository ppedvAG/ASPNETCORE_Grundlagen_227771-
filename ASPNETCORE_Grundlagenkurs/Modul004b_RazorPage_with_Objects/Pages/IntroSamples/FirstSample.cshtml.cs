using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modul004b_RazorPage_with_Objects.Models;

namespace Modul004b_RazorPage_with_Objects.Pages.IntroSamples
{
    public class FirstSampleModel : PageModel
    {
        public Movie MovieObj { get; set; }


        public void OnGet()
        {
            MovieObj = new Movie()
            {
                Id = 1,
                Name = "Coda",
                Description = "Talentierte Sängerin",
                Price = 11m,
                Genre = GenreType.Drame
            };
        }
    }
}
