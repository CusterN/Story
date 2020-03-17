using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueFrequencies
{
    public class DeleteModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public DeleteModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ValueFrequency ValueFrequency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ValueFrequency = await _context.ValueFrequency.FirstOrDefaultAsync(m => m.Id == id);

            if (ValueFrequency == null)
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

            ValueFrequency = await _context.ValueFrequency.FindAsync(id);

            if (ValueFrequency != null)
            {
                _context.ValueFrequency.Remove(ValueFrequency);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
