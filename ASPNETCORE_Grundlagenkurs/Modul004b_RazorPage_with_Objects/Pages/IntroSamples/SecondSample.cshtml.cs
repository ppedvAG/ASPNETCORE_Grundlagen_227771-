using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modul004b_RazorPage_with_Objects.Models;

namespace Modul004b_RazorPage_with_Objects.Pages.IntroSamples
{
    public class SecondSampleModel : PageModel
    {
        //ViewModel Struktur
        
        //Warum eine VM-Struktur?
        
        //Wir können hier mehrere Public - Properties anlegen, auf die wir zugreifen. Die Properties umfassen die Ausgaben der UI. 
        public IList<Movie> Movies { get; set; } = new List<Movie>();

        public void OnGet()
        {
            Movies.Add(new Movie { Id = 1, Name = "Jurassic Park", Description = "TRex wird Veggie", Genre = GenreType.Action, Price = 10m });
            Movies.Add(new Movie { Id = 2, Name = "Jurassic Park 1", Description = "Dinos züchten MEnschen", Genre = GenreType.Action, Price = 12m });
            Movies.Add(new Movie { Id = 3, Name = "Jurassic Park 2", Description = "TRex ist kein Veggie", Genre = GenreType.Action, Price = 11m });
            Movies.Add(new Movie { Id = 4, Name = "Batman", Description = "TRex wird Veggie", Genre = GenreType.Action, Price = 20m });
        }
    }
}
