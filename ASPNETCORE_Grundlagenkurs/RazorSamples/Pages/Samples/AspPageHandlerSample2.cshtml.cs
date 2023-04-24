using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSamples.Pages.Samples
{
    public class AspPageHandlerSample2Model : PageModel
    {
        [BindProperty]
        public int Ergebnis { get; set; }


        public void OnGet()
        {
            Ergebnis = 0;
        }

        public void OnPostAdd()
        {
            int a, b = 0;
            int.TryParse(Request.Form["eins"].FirstOrDefault(), out a);
            int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b);
            Ergebnis = a + b;
        }


        public void OnPostSub()
        {
            int a, b = 0;
            int.TryParse(Request.Form["eins"].FirstOrDefault(), out a);
            int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b);
            Ergebnis = a - b;
        }


        public void OnPostMult()
        {
            int a, b = 0;
            int.TryParse(Request.Form["eins"].FirstOrDefault(), out a);
            int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b);
            Ergebnis = a * b;
        }

        public void OnPostDiv()
        {
            int a, b = 0;
            int.TryParse(Request.Form["eins"].FirstOrDefault(), out a);
            int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b);
            Ergebnis = a / b;
        }
    }
}
