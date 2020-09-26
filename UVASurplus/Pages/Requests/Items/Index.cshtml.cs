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
    public class IndexModel : PageModel
    {
        private readonly UVASurplus.Data.UVASurplusContext _context;

        public IndexModel(UVASurplus.Data.UVASurplusContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
