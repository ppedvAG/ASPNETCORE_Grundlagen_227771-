﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCore_with_LazyLoading.Data;
using EFCore_with_LazyLoading.Models;

namespace EFCore_with_LazyLoading.Pages.Languages
{
    public class DeleteModel : PageModel
    {
        private readonly EFCore_with_LazyLoading.Data.GeoDbContext _context;

        public DeleteModel(EFCore_with_LazyLoading.Data.GeoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Language Language { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Languages == null)
            {
                return NotFound();
            }

            var language = await _context.Languages.FirstOrDefaultAsync(m => m.Id == id);

            if (language == null)
            {
                return NotFound();
            }
            else 
            {
                Language = language;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Languages == null)
            {
                return NotFound();
            }
            var language = await _context.Languages.FindAsync(id);

            if (language != null)
            {
                Language = language;
                _context.Languages.Remove(Language);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
