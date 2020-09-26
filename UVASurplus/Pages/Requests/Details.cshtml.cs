using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UVASurplus.Data;
using UVASurplus.Models;

namespace UVASurplus.Pages.Requests
{
    public class DetailsModel : PageModel
    {
        private readonly UVASurplus.Data.UVASurplusContext _context;

        public DetailsModel(UVASurplus.Data.UVASurplusContext context)
        {
            _context = context;
        }

        public Request Request { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Request = await _context.Request
                .Include(c => c.Items)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Request == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
