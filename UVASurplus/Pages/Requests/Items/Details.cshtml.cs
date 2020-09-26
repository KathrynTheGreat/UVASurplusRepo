using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UVASurplus.Data;
using UVASurplus.Models;

namespace UVASurplus.Pages.Requests.Items
{
    public class DetailsModel : PageModel
    {
        private readonly UVASurplus.Data.UVASurplusContext _context;

        public DetailsModel(UVASurplus.Data.UVASurplusContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FirstOrDefaultAsync(m => m.ID == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
