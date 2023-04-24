using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages.IOCSamples
{
    public class Sample3Model : PageModel
    {
        public void OnGet()
        {
            ITimeService timeService = this.HttpContext.RequestServices.GetService<ITimeService>();
            ITimeService timeService2 = this.HttpContext.RequestServices.GetRequiredService<ITimeService>();
        }
    }
}
