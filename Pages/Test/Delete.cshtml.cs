#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using radzure.Data;
using radzure.Models;

namespace radzure.Pages.Test
{
    public class DeleteModel : PageModel
    {
        private readonly radzure.Data.radzureContext _context;

        public DeleteModel(radzure.Data.radzureContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Stock Stock { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stock = await _context.Stock.FirstOrDefaultAsync(m => m.ItemNo == id);

            if (Stock == null)
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

            Stock = await _context.Stock.FindAsync(id);

            if (Stock != null)
            {
                _context.Stock.Remove(Stock);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
