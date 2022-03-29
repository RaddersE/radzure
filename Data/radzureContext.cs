#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using radzure.Models;

namespace radzure.Data
{
    public class radzureContext : DbContext
    {
        public radzureContext (DbContextOptions<radzureContext> options)
            : base(options)
        {
        }

        public DbSet<radzure.Models.Stock> Stock { get; set; }
    }
}
