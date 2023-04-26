using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StateManagement.Models;
using System.Text.Json;

namespace StateManagement.Pages
{
    public class SessionStartModel : PageModel
    {
        public void OnGet()
        {
            this.HttpContext.Session.SetInt32("Lottozahlen", 1234567);
            this.HttpContext.Session.SetString("email", "kevinw@ppedv.de");


            //Komplexes Objekt in Session legen

            Movie movie = new()
            {
                Id = 1,
                Title = "Triangle of Sdness",
                Description = "Sehr guter Film"
            };


            //Objekt wird zu einer JSON-Struktur -> String
            string json = JsonSerializer.Serialize(movie);
            this.HttpContext.Session.SetString("film", json);
        }
    }
}
