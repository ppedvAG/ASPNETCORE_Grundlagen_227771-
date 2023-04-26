using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Advanced.Pages
{
    public class ShowBrowserNameModel : PageModel
    {
        public string Name { get; set; }    
        public void OnGet()
        {
            Name = Request.Headers["User-Agent"].ToString();
        }
    }
}
