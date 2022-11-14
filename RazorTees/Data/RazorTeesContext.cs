using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorTees.Models;

namespace RazorTees.Data
{
    public class RazorTeesContext : DbContext
    {
        public RazorTeesContext (DbContextOptions<RazorTeesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorTees.Models.Tees>? Tees { get; set; }
    }
}
