using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueTypes
{
    public class EditModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public EditModel(Story.Data.StoryContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ValueType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ValueTypeExists(ValueType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ValueTypeExists(int id)
        {
            return _context.ValueType.Any(e => e.Id == id);
        }
    }
}
