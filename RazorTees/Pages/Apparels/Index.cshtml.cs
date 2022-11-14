using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTees.Data;
using RazorTees.Models;

namespace RazorTees.Pages.Apparels
{
    public class IndexModel : PageModel
    {
        private readonly RazorTees.Data.RazorTeesContext _context;

        public IndexModel(RazorTees.Data.RazorTeesContext context)
        {
            _context = context;
        }

        public IList<Tees> Tees { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tees != null)
            {
                Tees = await _context.Tees.ToListAsync();
            }
        }
    }
}
