using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Story.Data;
using Story.Models;

namespace Story.Pages.Comments
{
    public class CreateModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public CreateModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public Story.Models.Story story { get; set; }

        public IActionResult OnGet(int? StoryId)
        {
            if(StoryId == null)
            {
                ViewData["StoryId"] = new SelectList(_context.Story, "Id", "Title");
                return Page();
            } else
            {
                //limit the story to be the one you came in with.
                ViewData["StoryId"] = new SelectList(_context.Story, "Id", "Title", StoryId);
                return Page();
            }
      
        }

        [BindProperty]
        public Comment Comment { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Comment.Add(Comment);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Details",new { Id = Comment.StoryId } );
        }
    }
}
