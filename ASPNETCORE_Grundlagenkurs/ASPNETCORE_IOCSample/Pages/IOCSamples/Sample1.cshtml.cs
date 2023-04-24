using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages.IOCSamples
{
    public class Sample1Model : PageModel
    {
        private readonly ITimeService _timeService;


        //Konstruktor Injection -> Wird verwendet in Razor Pages und in MVC mit dem Benefitz, dass man mehrere Views mit einem Service bedienen kann
        public Sample1Model(ITimeService timeService)
        {
            _timeService = timeService;
        }


        //Sample2
        //Methoden Injection ->  Wird im MVC verwendet. Bietet einen IOC Dienst für nur eine Methode an.
        public void OnGet([FromServices] ITimeService timeService)
        {
            //timeServie gilt hier nur lokal 
        }
    }
}
