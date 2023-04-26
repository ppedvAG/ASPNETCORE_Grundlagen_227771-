using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StateManagement.Models;
using System.Text.Json;

namespace StateManagement.Pages
{
    public class SessionEndeModel : PageModel
    {
        public void OnGet()
        {
            int? lottozahlen = HttpContext.Session.GetInt32("Lottozahlen");
            string email = HttpContext.Session.GetString("email").ToString();


            string json = HttpContext.Session.GetString("film");
            Movie movie = JsonSerializer.Deserialize<Movie>(json);
        }
    }
}
