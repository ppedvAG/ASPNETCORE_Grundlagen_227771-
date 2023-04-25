using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ValidierungsSamples.Data;
using ValidierungsSamples.Models;

namespace ValidierungsSamples.Pages.MovieStore
{
    public class CreateModel : PageModel
    {
        private readonly ValidierungsSamples.Data.MovieDbContext _context;

        public CreateModel(ValidierungsSamples.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //Hier können wir auch Regeln hinterlegen

            if(Movie.Title == "The Crow")
            {
                ModelState.AddModelError("Movie.Title", "Der Film steht auf dem Index");
            }


            if (!ModelState.IsValid || _context.Movie == null || Movie == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
