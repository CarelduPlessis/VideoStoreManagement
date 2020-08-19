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
    public class IndexModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public IndexModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

        public IList<MovieRental> MovieRental { get;set; }

        public async Task OnGetAsync()
        {
            MovieRental = await _context.MovieRental
                .Include(m => m.customer)
                .Include(m => m.movie).ToListAsync();
        }
    }
}
