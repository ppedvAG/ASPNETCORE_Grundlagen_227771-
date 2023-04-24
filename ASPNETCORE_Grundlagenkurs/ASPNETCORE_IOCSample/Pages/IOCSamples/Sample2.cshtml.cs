using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages.IOCSamples
{
    public class Sample2Model : PageModel
    {
        //Methoden Injection 
        public void OnGet([FromServices] ITimeService service)
        {
            //... kann man nur lokal in dieser Methode verwenden 
        }
    }
}
