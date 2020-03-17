using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Story.Data;
using Story.Models;

namespace Story.Pages.ValueTypes
{
    public class DetailsModel : PageModel
    {
        private readonly Story.Data.StoryContext _context;

        public DetailsModel(Story.Data.StoryContext context)
        {
            _context = context;
        }

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
    }
}
