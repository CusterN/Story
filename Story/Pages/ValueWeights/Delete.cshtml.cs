using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueWeights
{
    public class DeleteModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public DeleteModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ValueWeight ValueWeight { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ValueWeight = await _context.ValueWeight.FirstOrDefaultAsync(m => m.Id == id);

            if (ValueWeight == null)
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

            ValueWeight = await _context.ValueWeight.FindAsync(id);

            if (ValueWeight != null)
            {
                _context.ValueWeight.Remove(ValueWeight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
