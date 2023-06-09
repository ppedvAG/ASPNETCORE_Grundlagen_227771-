﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCore_with_LazyLoading.Data;
using EFCore_with_LazyLoading.Models;

namespace EFCore_with_LazyLoading.Pages.Continents
{
    public class EditModel : PageModel
    {
        private readonly EFCore_with_LazyLoading.Data.GeoDbContext _context;

        public EditModel(EFCore_with_LazyLoading.Data.GeoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Continent Continent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Continents == null)
            {
                return NotFound();
            }

            var continent =  await _context.Continents.FirstOrDefaultAsync(m => m.Id == id);
            if (continent == null)
            {
                return NotFound();
            }
            Continent = continent;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Continent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContinentExists(Continent.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ContinentExists(int id)
        {
          return (_context.Continents?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
