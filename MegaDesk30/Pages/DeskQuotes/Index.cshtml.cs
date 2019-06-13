using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk30.Models;

namespace MegaDesk30.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk30.Models.MegaDesk30Context _context;

        public IndexModel(MegaDesk30.Models.MegaDesk30Context context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var custNames = from m in _context.DeskQuote
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                custNames = custNames.Where(c => c.customerName.Contains(SearchString));
            }
            

            DeskQuote = await custNames.ToListAsync();
        }
    }
}




  
