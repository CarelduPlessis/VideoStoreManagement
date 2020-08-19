using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoStoreManagement.Data;
using VideoStoreManagement.Models;

namespace VideoStoreManagement.Pages.MovieRentalPages
{
    public class EditModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public EditModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MovieRental MovieRental { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieRental = await _context.MovieRental
                .Include(m => m.customer)
                .Include(m => m.movie).FirstOrDefaultAsync(m => m.Id == id);

            if (MovieRental == null)
            {
                return NotFound();
            }
           ViewData["CustomerFK"] = new SelectList(_context.Customer, "Id", "FullName");
           ViewData["MovieFK"] = new SelectList(_context.Movie, "Id", "Title");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MovieRental).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieRentalExists(MovieRental.Id))
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

        private bool MovieRentalExists(int id)
        {
            return _context.MovieRental.Any(e => e.Id == id);
        }
    }
}
