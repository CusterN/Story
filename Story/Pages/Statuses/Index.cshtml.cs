using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.Statuses
{
    public class IndexModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public IndexModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public IList<Models.Status> Status { get;set; }

        public async Task OnGetAsync()
        {
            Status = await _context.Status
                .OrderBy(s => s.SortOrder)
                .ToListAsync();
        }
    }
}
