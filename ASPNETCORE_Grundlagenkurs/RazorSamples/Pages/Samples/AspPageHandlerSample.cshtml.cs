using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSamples.Pages.Samples
{
    public class AspPageHandlerSampleModel : PageModel
    {
        [BindProperty]
        public int Ergebnis { get; set; }   


        public void OnGet()
        {
            Ergebnis = 0;
        }

        public void OnPost()
        {
            int a, b = 0;

            int.TryParse(Request.Form["eins"], out a);
            int.TryParse(Request.Form["zwei"], out b);

            Ergebnis = a + b; //Wird aktualisiert 

        }
    }
}
