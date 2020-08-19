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
    public class IndexModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public IndexModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
