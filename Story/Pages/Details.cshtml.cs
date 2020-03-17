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
    public class DetailsModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public DetailsModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public Story.Models.Story Story { get; set; }
        public IList<Comment> Comment { get; set; }

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

            Comment = await _context.Comment.Where(c => c.StoryId == id).OrderByDescending(c => c.CreateDate).ToListAsync();

            if (Story == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
