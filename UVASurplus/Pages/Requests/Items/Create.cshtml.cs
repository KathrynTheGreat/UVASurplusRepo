using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UVASurplus.Data;
using UVASurplus.Models;

namespace UVASurplus.Pages.Requests.Items
{
    public class CreateModel : PageModel
    {
        private readonly UVASurplus.Data.UVASurplusContext _context;

        public CreateModel(UVASurplus.Data.UVASurplusContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; }
        

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Item.RequestID = Convert.ToInt32(RouteData.Values["id"]);
            _context.Item.Add(Item);
            
            await _context.SaveChangesAsync();

            return RedirectToPage("../Details", new { id = RouteData.Values["id"] });
        }
    }
}
