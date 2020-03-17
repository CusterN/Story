using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueFrequencies
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
            return Page();
        }

        [BindProperty]
        public ValueFrequency ValueFrequency { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ValueFrequency.Add(ValueFrequency);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
