using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSamples.Pages.Samples
{
    public class PageHandlerSampleModel : PageModel
    {
        public string MethodenEinstieg { get; set; }


        public void OnGet()
        {
            MethodenEinstieg = "OnGet()";
        }

        //Multiple handlers matched. The following handlers matched route data and had all constraints satisfied: -> Deswegen verwenden wir OnGetDemo (angabe eines Handlers) 

        //public void OnGet(string Test)
        //{
        //    MethodenEinstieg = "OnGetTest";
        //}


        //
        public void OnGetDemo()
        {
            MethodenEinstieg = "OnGetDemo";
        }

        public void OnGetDemoWithParam(string param)
        {
            MethodenEinstieg = "OnGetDemoWithParam";
        }
    }
}
