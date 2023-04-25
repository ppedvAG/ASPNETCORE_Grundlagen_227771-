﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_with_EFCore_Intro.Data;
using RazorPages_with_EFCore_Intro.Models;

namespace RazorPages_with_EFCore_Intro.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages_with_EFCore_Intro.Data.MovieDbContext _context;

        public DetailsModel(RazorPages_with_EFCore_Intro.Data.MovieDbContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
