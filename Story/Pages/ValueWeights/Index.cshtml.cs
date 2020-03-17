using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueWeights
{
    public class IndexModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public IndexModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

        public IList<ValueWeight> ValueWeight { get;set; }

        public async Task OnGetAsync()
        {
            ValueWeight = await _context.ValueWeight.ToListAsync();
        }
    }
}
