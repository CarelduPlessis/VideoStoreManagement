using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoStoreManagement.Data;
using VideoStoreManagement.Models;

namespace VideoStoreManagement.Pages.CustomerPages
{
    public class DeleteModel : PageModel
    {
        private readonly VideoStoreManagement.Data.VideoStoreManagementContext _context;

        public DeleteModel(VideoStoreManagement.Data.VideoStoreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            string isThereError = "false";
            ViewData["checkError"] = isThereError;
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FindAsync(id);

            if (Customer != null)
            {
                _context.Customer.Remove(Customer);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                    ViewData["errorMessage"] = ex.Message;
                    ViewData["customErrorMessagePart1"] = "If data is not deleted we recomend you to first delete this customer from video rentals";
                    ViewData["customErrorMessagePart2"] = "If error continue afterwards contact your IT support!";
                    isThereError = "true";
                    ViewData["checkError"] = isThereError;

                }
            }
            if (isThereError == "true")
            {
                return null;
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }
    }
}
