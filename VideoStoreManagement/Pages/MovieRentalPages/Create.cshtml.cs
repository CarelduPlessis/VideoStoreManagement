using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VideoStoreManagement.Data;
using VideoStoreManagement.Models;

namespace VideoStoreManagement.Pages.MovieRentalPages
{
    public class CreateModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public CreateModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerFK"] = new SelectList(_context.Customer, "Id", "FullName");
        ViewData["MovieFK"] = new SelectList(_context.Movie, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public MovieRental MovieRental { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MovieRental.Add(MovieRental);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
