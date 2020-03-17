using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueFrequencies
{
    public class IndexModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public IndexModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public IList<ValueFrequency> ValueFrequency { get;set; }

        public async Task OnGetAsync()
        {
            ValueFrequency = await _context.ValueFrequency.ToListAsync();
        }
    }
}
