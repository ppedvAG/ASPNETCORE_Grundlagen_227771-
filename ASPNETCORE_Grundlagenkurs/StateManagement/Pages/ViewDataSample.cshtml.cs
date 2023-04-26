using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateManagement.Pages
{
    public class ViewDataSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData.Add("Lottozahlen", "12-23-54-25-42-52-8");
            ViewData.Add("EmailAdress", "kevinw@ppedv.de");

        }
    }
}
