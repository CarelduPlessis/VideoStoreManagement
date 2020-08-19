using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoStoreManagement.Data;
using VideoStoreManagement.Models;

namespace VideoStoreManagement.Pages.MovieRentalPages
{
    public class DeleteModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public DeleteModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieRental = await _context.MovieRental.FindAsync(id);

            if (MovieRental != null)
            {
                _context.MovieRental.Remove(MovieRental);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
