using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoStoreManagement.Data;
using VideoStoreManagement.Models;

namespace VideoStoreManagement.Pages.MoviePages
{
    public class DetailsModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public DetailsModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
