using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UVASurplus.Data;
using UVASurplus.Models;
using UVASurplus.Models.ViewModels;

namespace UVASurplus.Pages.Requests
{
    public class IndexModel : PageModel
    {
        private readonly UVASurplus.Data.UVASurplusContext _context;

        public IndexModel(UVASurplus.Data.UVASurplusContext context)
        {
            _context = context;
        }

        public IList<Request> Requests { get;set; }
        public IList<Item> Items { get; set; }

        //new code from thing


        public async Task OnGetAsync()
        {
            
            Requests = await _context.Request
                .Include(i => i.Items)
                .AsNoTracking()
                .OrderBy(i => i.ID)
                .ToListAsync();

        }
    }
}
