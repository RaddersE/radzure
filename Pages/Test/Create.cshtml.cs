#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using radzure.Data;
using radzure.Models;

namespace radzure.Pages.Test
{
    public class CreateModel : PageModel
    {
        private readonly radzure.Data.radzureContext _context;

        public CreateModel(radzure.Data.radzureContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Stock Stock { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Stock.Add(Stock);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
