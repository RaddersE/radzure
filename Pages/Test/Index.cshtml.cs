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
    public class IndexModel : PageModel
    {
        private readonly radzure.Data.radzureContext _context;

        public IndexModel(radzure.Data.radzureContext context)
        {
            _context = context;
        }

        public IList<Stock> Stock { get;set; }

        public async Task OnGetAsync()
        {
            Stock = await _context.Stock.ToListAsync();
        }
    }
}
