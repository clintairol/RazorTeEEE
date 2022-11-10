using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTees.Data;
using RazorTees.Models;

namespace RazorTees.Pages.Apparels
{
    public class CreateModel : PageModel
    {
        private readonly RazorTees.Data.RazorTeesContext _context;

        public CreateModel(RazorTees.Data.RazorTeesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tees Tees { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Tees == null || Tees == null)
            {
                return Page();
            }

            _context.Tees.Add(Tees);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
