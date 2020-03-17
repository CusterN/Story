using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueTypes
{
    public class DeleteModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public DeleteModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.ValueType ValueType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ValueType = await _context.ValueType.FirstOrDefaultAsync(m => m.Id == id);

            if (ValueType == null)
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

            ValueType = await _context.ValueType.FindAsync(id);

            if (ValueType != null)
            {
                _context.ValueType.Remove(ValueType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
