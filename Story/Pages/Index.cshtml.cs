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
    public class IndexModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public IndexModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public IList<Story.Models.Story> Story { get;set; }

        public async Task OnGetAsync()
        {
            Story = await _context.Story
                .Include(s => s.Group)
                .Include(s => s.Status)
                .Include(s => s.ValueFrequency)
                .Include(s => s.ValueType)
                .Include(s => s.ValueWeight)
                .OrderBy(s => s.CreateDate)
                .OrderBy(s => s.Status.SortOrder)
                .ToListAsync();
        }
    }
}
