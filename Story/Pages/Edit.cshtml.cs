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

namespace Story.Pages
{
    public class EditModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public EditModel(Story.Data.StoryContext context)
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
                .Include(s => s.ValueType).FirstOrDefaultAsync(m => m.Id == id);

            if (Story == null)
            {
                return NotFound();
            }
           ViewData["GroupId"] = new SelectList(_context.Group, "Id", "Description");
           ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "Id", "Description");
           ViewData["ValueFrequencyId"] = new SelectList(_context.Set<ValueFrequency>(), "Id", "Description");
           ViewData["ValueTypeId"] = new SelectList(_context.Set<Models.ValueType>(), "Id", "Description");
            ViewData["ValueWeightId"] = new SelectList(_context.Set<Models.ValueWeight>(), "Id", "Hint");
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

            _context.Attach(Story).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryExists(Story.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new { Story.Id });
        }

        private bool StoryExists(int id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
