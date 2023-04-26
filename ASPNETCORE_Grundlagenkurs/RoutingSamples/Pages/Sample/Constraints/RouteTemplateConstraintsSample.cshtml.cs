using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoutingSamples.Pages.Sample.Constraints
{
    public class RouteTemplateConstraintsSampleModel : PageModel
    {
        //Mit Default-Page Directive -> https://localhost:7227/RouteTemplateConstraints?id=123&uid=456
        public void OnGet(int id, int? uid)
        {
        }
    }
}
