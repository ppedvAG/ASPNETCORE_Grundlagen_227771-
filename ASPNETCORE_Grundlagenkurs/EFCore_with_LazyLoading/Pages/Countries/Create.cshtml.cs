using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EFCore_with_LazyLoading.Data;
using EFCore_with_LazyLoading.Models;

namespace EFCore_with_LazyLoading.Pages.Countries
{
    public class CreateModel : PageModel
    {
        private readonly EFCore_with_LazyLoading.Data.GeoDbContext _context;

        public CreateModel(EFCore_with_LazyLoading.Data.GeoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ContinentId"] = new SelectList(_context.Continents, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Country Country { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("Country.LanguagesInCountries");
            ModelState.Remove("Country.Continet");



            if (Country.Name == "Atlantis")
            {
                ModelState.AddModelError("Country.Name", "Atlantis gibt es nicht");
            }

            if (!ModelState.IsValid || _context.Countries == null || Country == null)
            {
                ViewData["ContinentId"] = new SelectList(_context.Continents, "Id", "Name");

                return Page();
            }

            _context.Countries.Add(Country);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
