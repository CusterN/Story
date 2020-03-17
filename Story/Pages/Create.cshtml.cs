using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Story.Data;
using Story.Models;

namespace Story.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public CreateModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GroupId"] = new SelectList(_context.Group, "Id", "Description");
        ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "Id", "Description");
        ViewData["ValueFrequencyId"] = new SelectList(_context.Set<ValueFrequency>(), "Id", "Description");
        ViewData["ValueTypeId"] = new SelectList(_context.Set<Models.ValueType>(), "Id", "Description");
        ViewData["ValueWeightId"] = new SelectList(_context.Set<Models.ValueWeight>(), "Id", "Hint");
            return Page();
        }

        [BindProperty]
        public Story.Models.Story Story { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Story.Add(Story);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
