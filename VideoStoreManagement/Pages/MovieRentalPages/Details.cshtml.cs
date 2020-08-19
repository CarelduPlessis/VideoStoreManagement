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
    public class DetailsModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public DetailsModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

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
    }
}
