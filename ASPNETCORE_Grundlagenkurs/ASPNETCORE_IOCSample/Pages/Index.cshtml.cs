using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITimeService _timeService;

        //Konstuktor - Injection
        public IndexModel(ILogger<IndexModel> logger, ITimeService service)
        {
            _logger = logger;
            _timeService = service;
        }

        public void OnGet()
        {

        }
    }
}