using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public DeleteModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Story.Models.Story Story { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Story = await _context.Story
                .Include(s => s.Group)
                .Include(s => s.Status)
                .Include(s => s.ValueFrequency)
                .Include(s => s.ValueWeight)
                .Include(s => s.ValueType).FirstOrDefaultAsync(m => m.Id == id);

            if (Story == null)
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

            Story = await _context.Story.FindAsync(id);

            if (Story != null)
            {
                _context.Story.Remove(Story);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
