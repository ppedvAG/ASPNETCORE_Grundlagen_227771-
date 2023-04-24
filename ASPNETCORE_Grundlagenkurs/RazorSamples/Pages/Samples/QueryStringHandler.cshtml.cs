using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSamples.Pages.Samples
{
    public class QueryStringHandlerModel : PageModel
    {
        //https://localhost:7290/Samples/QueryStringHandler?name=otto&alter=44&lieblingsessen=Lassagne
        public ContentResult OnGet(string name, string alter, string lieblingsessen)
        {
            return Content(name + " " + alter + " " + lieblingsessen);
        }
    }
}
